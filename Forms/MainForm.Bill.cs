using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AccommodationManagerApp.Forms.Bill;
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
    }
}


