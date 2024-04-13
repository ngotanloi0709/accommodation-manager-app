using System;
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
                SelectBillAgain(bill);
            }
        }

        private void InsertBillIntoListView(List<Bill> bills) {
            ListViewBill.Items.Clear();
            foreach (var bill in bills) {
                var item = new ListViewItem(bill.Id.ToString());
                item.SubItems.Add(FormatText.IntegerToVnd(bill.RentFee));
                item.SubItems.Add(bill.Contract?.Room.RoomNumber ?? "Trống");
                item.SubItems.Add(bill.User.Name);
                item.SubItems.Add(bill.DateOfBill.ToString("MM/yyyy"));
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

        private void BtnEmailThisMonth_Click(object sender, EventArgs e)
        {
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
                Room room = _roomService.GetById(contract.RoomId);
                User user = _userService.GetById(contract.UserId);
                string subject = "Reminder: Remind Unpaid Tennant Bill";
                string body = "<html><body>";
                body += "<h2>Gửi " + user.Name + ",</h2>";
                body +=
                    "<p>Bạn có một hóa đơn chưa được thanh toán tháng này, hãy chú ý thanh toán sớm nhất:</p>";
                body += "<ul style=`list-style-type:none`>";
                body += "<li>Tiền thuê nhà tháng: " + bill.DateOfBill.Month + " </li>";
                body += "<li>Phòng số: " + room.RoomNumber + " </li>";
                body += "<li>Số điện: " + bill.ElectricityQuantity + " kWh  - Đơn giá: " +
                        bill.ElectricityFee.ToString("N0") +
                        " VND/kwh</li>";
                body += "<li>Số nước: " + bill.WaterQuantity + " m3  - Đơn giá: " + bill.WaterFee.ToString("N0") +
                        " VND/m3</li>";
                body += "<li>Tiền thuê nhà: " + bill.RentFee.ToString("N0") + " VND</li>";
                body += "<li>Tổng tiền điện: " + (bill.ElectricityQuantity * bill.ElectricityFee).ToString("N0") +
                        " VND</li>";
                body += "<li>Tổng tiền nước: " + (bill.WaterQuantity * bill.WaterFee).ToString("N0") + " VND</li>";
                body += "<li>Internet: " + bill.InternetFee.ToString("N0") + " VND</li>";
                body += "<li>Phí gửi xe: " + bill.VehicleFee.ToString("N0") + " VND</li>";
                body += "<li>Tổng tiền phải trả: " +
                        (bill.RentFee + bill.ElectricityQuantity * bill.ElectricityFee +
                         bill.WaterQuantity * bill.WaterFee +
                         bill.InternetFee + bill.VehicleFee).ToString("N0") + " VND</li>";
                body += "</ul>";
                body += "<p>Hãy chắc chắn bạn sẽ thanh toán, cảm ơn!</p>";
                body += "<p>Trân trọng,</p>";
                body += "<p>Quản lý nhà trọ</p>";
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
            if (bill == null) return;
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
            
            var billStatusForm = new BillStatusForm(bill);
            billStatusForm.ShowDialog();

            if (billStatusForm.DialogResult == DialogResult.Cancel) return;
            
            if (billStatusForm.DialogResult == DialogResult.OK) {
                new ToastForm("Cập nhật trạng thái hoá đơn thành công!").Show();
                LoadBillData();
                SelectBillAgain(bill);
            }
        }

        private void btnEmailAllMonth_Click(object sender, EventArgs e)
        {
            var confirm = new ConfirmationForm("Xác nhận gửi mail cho danh sách chưa thanh toán trong tất cả các tháng?");
            var result = confirm.ShowDialog();

            if (result != DialogResult.Yes)
            {
                return;
            }
            List<Bill> Bill = _billService.GetAll();
            List<Bill> bills = Bill.Where(bill => bill.Status == BillStatus.Unpaid).ToList();
            if(bills.Count == 0)
            {
                new ToastForm("Không có hóa đơn nào chưa thanh toán", true).Show();
            }
            else
            {
                foreach (Bill bill in bills)
                {
                    Task.Run(() =>
                    {
                        SendEmail(bill);
                    });
                }
                new ToastForm("Đã gửi mail cho danh sách chưa thanh toán!").Show();
            }
        }

        private void SelectBillAgain(Bill bill) {
            var index = Bills.IndexOf(bill);

            if (ListViewBill.Items.Count > index) {
                ListViewBill.Items[index].Selected = true;
                ListViewBill.Select();
            }
        }

        private void LoadBillData()
        {
            Bills = _billService.GetAllWithContractWithRoomAndUser();
            InsertBillIntoListView(Bills);
        }

        // Query System
        private void ButtonPriceSearch_Click(object sender, EventArgs e)
        {
            BillStatus state = QueryUtils.ToBillStatus((string)comboBoxState.SelectedItem);
            List<object> time = QueryUtils.ChangeTextToDate((string)comboBoxTime.SelectedItem);
            List<string> text = QueryUtils.ChangeSearchInput((string) comboBoxVolumn.SelectedItem, textBoxSearch.Text);
            int? minPrice = int.TryParse(textBoxMinPrice.Text, out int min) ? min : (int?)null;
            int? maxPrice = int.TryParse(textBoxMaxPrice.Text, out int max) ? max : (int?)null;

            if (QueryUtils.CheckMinMaxPrice(minPrice, maxPrice))
            {
                Bills = _billService.GetByCustomizeQuery(state, time, text, minPrice, maxPrice);
                InsertBillIntoListView(Bills);
            }
            else
                new ToastForm("Xin mời nhập giá sàn thấp hơn giá trần", true).Show();
            return;
        }
    }
}

