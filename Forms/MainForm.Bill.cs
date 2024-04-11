﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Util;
using Exception = System.Exception;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm {
        private Bill SelectBill() {
            if (ListViewBill.SelectedItems.Count > 0) {
                var index = ListViewBill.SelectedItems[0].Index;
                if (index < Bills.Count) return Bills[index];
            }
            return null;
        }

        private void PreviewBill(object sender, EventArgs e) {
            var bill = SelectBill();
            if (bill == null)
            {
                new ToastForm("Hãy chọn hoá đơn cần thao tác!", true).Show();
                return;
            }
                var billDetail = new BillDetail(bill);
            billDetail.ShowDialog();
        }

        private void UpdateBill(object sender, EventArgs e) {
            var bill = SelectBill();
            if (bill == null)
            {
                new ToastForm("Hãy chọn hoá đơn cần thao tác!", true).Show();
                return;
            }

            var billForm = new BillForm(bill, waterPrice, electricityPrice, internetPrice);
            billForm.ShowDialog();
            
            if (billForm.DialogResult == DialogResult.OK) {
                // Task.Run(() => {
                //     SendEmail(bill);
                //     LoadBillData();
                // });
                LoadBillData();
            }
        }

        private void InsertBillIntoListView(List<Bill> bills) {
            ListViewBill.Items.Clear();
            foreach (var bill in bills) {
                var item = new ListViewItem(bill.Id.ToString());
                item.SubItems.Add(bill.ElectricityQuantity.ToString());
                item.SubItems.Add(bill.WaterQuantity.ToString());
                item.SubItems.Add(bill.Contract?.Room.RoomNumber ?? "Trống");
                item.SubItems.Add(bill.User.Name);
                item.SubItems.Add(bill.DateOfBillFormatted);
                item.SubItems.Add(bill.Status.ToVietnamese());
                ListViewBill.Items.Add(item);
            }
        }

        private void DeleteBill(object sender, EventArgs e) {
            var bill = SelectBill();
            if (bill == null)
            {
                new ToastForm("Hãy chọn hoá đơn cần thao tác!", true).Show();
                return;
            }
            var confirmation = new ConfirmationForm("Xác nhận xóa hóa đơn?");
            var result = confirmation.ShowDialog();

            if (result == DialogResult.Yes) {
                _billService.Delete(bill.Id);
                LoadBillData();
            }
        }

        private void btnEmailThisMonth_Click(object sender, EventArgs e) {
            var confirm = new ConfirmationForm("Xác nhận gửi mail cho danh sách chưa thanh toán trong tháng?");
            var result = confirm.ShowDialog();
            if (result != DialogResult.Yes) return;

            List<Bill> bills = _billService.GetByUserIdInThisMonthAnhUnpaid();
            if (bills.Count == 0) {
                new ToastForm("Không có hóa đơn nào chưa thanh toán", true).Show();
            }
            else {
                Task.Run(() => {
                    foreach (Bill bill in bills) {
                        SendEmail(bill);
                    }
                });
                
                new ToastForm("Đã gửi mail cho danh sách chưa thanh toán!").Show();
            }
        }

        private void SendEmail(Bill bill) {
            try {
                Contract contract = _contractService.GetById(bill.ContractId);
                User user = _userService.GetById(contract.UserId);
                string subject = "Reminder: Remind Unpaid Tennant Bill";
                string body = "<html><body>";
                body += "<h2>Dear " + user.Name + ",</h2>";
                body +=
                    "<p>You have an unpaid bill in this month. Please pay it as soon as possible. Bill information:</p>";
                body += "<ul>";
                body += "<li>Số điện: " + bill.ElectricityQuantity + " kWh  - Đơn giá: " +
                        bill.ElectricityFee.ToString("N0") +
                        " VND/kwh</li>";
                body += "<li>Số nước: " + bill.WaterQuantity + " m3  - Đơn giá: " + bill.WaterFee.ToString("N0") +
                        " VND/m3</li>";
                body += "<li>Tiền thuê nhà: " + contract.Price.ToString("N0") + " VND</li>";
                body += "<li>Tổng tiền điện: " + (bill.ElectricityQuantity * bill.ElectricityFee).ToString("N0") +
                        " VND</li>";
                body += "<li>Tổng tiền nước: " + (bill.WaterQuantity * bill.WaterFee).ToString("N0") + " VND</li>";
                body += "<li>Internet: " + bill.InternetFee.ToString("N0") + " VND</li>";
                body += "<li>Tổng tiền phải trả: " +
                        (contract.Price + bill.ElectricityQuantity * bill.ElectricityFee +
                         bill.WaterQuantity * bill.WaterFee +
                         bill.InternetFee).ToString("N0") + " VND</li>";
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
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        private void ListViewBill_SelectedIndexChanged(object sender, EventArgs e) {
            var bill = SelectBill();
            if (bill == null)
            {
                new ToastForm("Hãy chọn hoá đơn cần thao tác!", true).Show();
                return;
            }
            LabelBillContractOwner.Text = bill.Contract.User.Name;
            LabelBillContractValue.Text = FormatText.IntegerToVnd(bill.Contract.Price);
            LabelBillTotal.Text = FormatText.IntegerToVnd(bill.GetTotalPrice());
            LabelBillRoomNumber.Text = bill.Contract.Room.RoomNumber;
            LabelBillContractEndDate.Text = bill.Contract.EndDate.ToString("dd/MM/yyyy");
        }

        private void ButtonUpdateBillStatus_Click(object sender, EventArgs e) {
            var bill = SelectBill();
            if (bill == null)
            {
                new ToastForm("Hãy chọn hoá đơn cần thao tác!", true).Show();
                return;
            }
        }

        // Query System
        private void LoadBillData()
        {
            Bills = _billService.GetAllWithContractWithRoomAndUser();
            InsertBillIntoListView(Bills);
        }
        private void buttonPriceSearch_Click(object sender, EventArgs e)
        {
            string text = textBoxSearch.Text;
            
            BillStatus state = BillUtils.ToBillStatus((string)comboBoxState.SelectedItem);
            string time = (string)comboBoxTime.SelectedItem;
            
            int? minPrice = int.TryParse(textBoxMinPrice.Text, out int min) ? min : (int?)null;
            int? maxPrice = int.TryParse(textBoxMaxPrice.Text, out int max) ? max : (int?)null;
            
            if (min > max) new ToastForm("Xin nhập giá sàn thấp hơn giá trần",true); return;


        }
    }
}

