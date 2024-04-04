using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using AccommodationManagerApp.Forms.Bill;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Util;
using BillModel = AccommodationManagerApp.Model.Bill;
namespace AccommodationManagerApp.Forms
{
    public partial class MainForm
    {
        private BillModel _bill;
        private BillModel SelectBill()
        {
            if(lstViewBill.SelectedItems.Count > 0)
            {
                var index = lstViewBill.SelectedItems[0].Index;                
                if(index < Bills.Count) return Bills[index];
            }
            new ToastForm("Mời chọn hóa đơn !", true).Show();
            return null;
        }
        private void PreviewBill(object sender, System.EventArgs e)
        {
            _bill = SelectBill();
            if (_bill == null) return;
            var billDetail = new BillDetail(_bill);
            billDetail.ShowDialog();
        }
        private void InsertBill(BillModel bill)
        {
            var billForm = new BillForm(bill);
            billForm.ShowDialog();
            LoadBillData();
        }
        private void UpdateBill(object sender, System.EventArgs e)
        {
            _bill = SelectBill();
            if (_bill == null) return;
            InsertBill(_bill);

            SendEmail(_bill);
        }
        private void LoadBillData()
        {
            Bills = _billService.GetAll();
            InsertBillIntoListView(Bills);
        }
        private void LoadBillDataInThisMonth()
        {
            Bills = Bills.Where(bill => bill.CreatedAt.Month == DateTime.Now.Month).ToList();
            InsertBillIntoListView(Bills);
        }
        private void InsertBillIntoListView(List<BillModel> bills)
        {
            lstViewBill.Items.Clear();
            foreach (var bill in bills)
            {
                var item = new ListViewItem(bill.Id.ToString());
                item.SubItems.Add(bill.ElecQuantity.ToString());
                item.SubItems.Add(bill.WaterQuantity.ToString());
                item.SubItems.Add(bill.Contract?.Room.RoomNumber.ToString() ?? "Trống");
                item.SubItems.Add(bill.CreatedAtFormatted);
                item.SubItems.Add(bill.Status.ToVietnamese());
                lstViewBill.Items.Add(item);
            }
        }
        private void DeleteBill(object sender, System.EventArgs e)
        {
            _bill = SelectBill();
            if (_bill == null) return;
            
            var confirmation = new ConfirmationForm("Xác nhận xóa hóa đơn?");
            var result = confirmation.ShowDialog();
            if (result == DialogResult.Yes)
            {
                _billService.Delete(_bill.Id);
                LoadBillData();
            }
        }    
        private void ComboBoxVolumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxVolumn.SelectedIndex)
            {
                case 0:
                    LoadBillData();
                    break;
                case 1:
                    LoadBillDataInThisMonth();
                    break;
            }
        }

        private void btnEmailThisMonth_Click(object sender, EventArgs e)
        {
            List<BillModel> bills = _billService.GetByUserIdInThisMonthAnhUnpaid();
            if (bills.Count == 0)
            {
                new ToastForm("Không có hóa đơn nào chưa thanh toán", true).Show();
                return;
            }
            else
            {
                foreach (BillModel bill in bills)
                {
                    SendEmail(bill);
                }
            }
        }

        private void SendEmail (BillModel bill)
        {
            try
            {
                User user = _userService.GetById(bill.UserId);
                Contract contract = _contractService.GetById(bill.ContractId);
                string subject = "Reminder: Remind Unpaid Tennant Bill";
                string body = "<html><body>";
                body += "<h2>Dear " + user.Name + ",</h2>";
                body += "<p>You have an unpaid bill in this month. Please pay it as soon as possible. Bill information:</p>";
                body += "<ul>";
                body += "<li>Số điện: " + bill.ElecQuantity + " kWh  - Đơn giá: " + bill.ElecFee.ToString("N0") + " VND/kwh</li>";
                body += "<li>Số nước: " + bill.WaterQuantity + " m3  - Đơn giá: " + bill.WaterFee.ToString("N0") + " VND/m3</li>";
                body += "<li>Tiền thuê nhà: " + contract.Price.ToString("N0") + " VND</li>";
                body += "<li>Tổng tiền điện: " + (bill.ElecQuantity * bill.ElecFee).ToString("N0") + " VND</li>";
                body += "<li>Tổng tiền nước: " + (bill.WaterQuantity * bill.WaterFee).ToString("N0") + " VND</li>";
                body += "<li>Internet: " + bill.InternetFee.ToString("N0") + " VND</li>";
                body += "<li>Tổng tiền phải trả: " + (contract.Price + bill.ElecQuantity * bill.ElecFee + bill.WaterQuantity * bill.WaterFee + bill.InternetFee).ToString("N0") + " VND</li>";
                body += "</ul>";
                body += "<p>Please make sure you pay the bill. Thank you!</p>";
                body += "<p>Best regards,</p>";
                body += "<p>Accommodation Manager</p>";
                body += "</body></html>";

                string senderEmail = "www.khuanhuan1964@gmail.com";
                string senderPassword = "udkx wfia bvkb qoqw";
                string recipientEmail = user.Email;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

                MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail, subject, body);
                mailMessage.IsBodyHtml = true;
                smtpClient.Send(mailMessage);

                new ToastForm("Đã gửi email nhắc nhở cho " + user.Name, false).Show();
            }
            catch(Exception e)
            {
                new ToastForm("Gửi email thất bại", true).Show();
            }
        }
    }
}


