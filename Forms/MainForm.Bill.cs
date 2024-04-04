using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Util;

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

            if (bill == null) {
                new ToastForm("Hãy chọn hoá đơn cần thao tác!", true).Show();
                return;
            } 
            
            var billDetail = new BillDetail(bill);
            billDetail.ShowDialog();
        }

        private void UpdateBill(object sender, EventArgs e) {
            var bill = SelectBill();
            
            if (bill == null) {
                new ToastForm("Hãy chọn hoá đơn cần thao tác!", true).Show();
                return;
            } 
            
            var billForm = new BillForm(bill, waterPrice, electricityPrice, internetPrice);
            billForm.ShowDialog();
        }

        private void LoadBillData() {
            Bills = _billService.GetAllWithContractWithRoomAndUser();
            InsertBillIntoListView(Bills);
        }

        private void LoadBillDataInThisMonth() {
            Bills = Bills.Where(bill => bill.DateOfBill.Month == DateTime.Now.Month).ToList();
            InsertBillIntoListView(Bills);
        }

        private void InsertBillIntoListView(List<Bill> bills) {
            ListViewBill.Items.Clear();
            foreach (var bill in bills) {
                var item = new ListViewItem(bill.Id.ToString());
                item.SubItems.Add(bill.ElectricityQuantity.ToString());
                item.SubItems.Add(bill.WaterQuantity.ToString());
                item.SubItems.Add(bill.Contract?.Room.RoomNumber ?? "Trống");
                item.SubItems.Add(bill.DateOfBillFormatted);
                item.SubItems.Add(bill.Status.ToVietnamese());
                ListViewBill.Items.Add(item);
            }
        }

        private void DeleteBill(object sender, EventArgs e) {
            var bill  = SelectBill();
            
            if (bill == null) {
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

        private void ComboBoxVolumn_SelectedIndexChanged(object sender, EventArgs e) {
            switch (comboBoxVolumn.SelectedIndex) {
                case 0:
                    LoadBillData();
                    break;
                case 1:
                    LoadBillDataInThisMonth();
                    break;
            }
        }
        
        private void ListViewBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bill  = SelectBill();

            if (bill == null) {
                return;
            } 
            
            LabelBillContractOwner.Text = bill.Contract.User.Name;
            LabelBillContractValue.Text = FormatText.IntegerToVnd(bill.Contract.Price);
            LabelBillTotal.Text = FormatText.IntegerToVnd(bill.GetTotalPrice());
            LabelBillRoomNumber.Text = bill.Contract.Room.RoomNumber;
            LabelBillContractEndDate.Text = bill.Contract.EndDate.ToString("dd/MM/yyyy");
        }

        private void ButtonUpdateBillStatus_Click(object sender, EventArgs e)
        {
            var bill = SelectBill();
            
            if (bill == null) {
                new ToastForm("Hãy chọn hoá đơn cần thao tác!", true).Show();
                return;
            } 
        }
    }
}