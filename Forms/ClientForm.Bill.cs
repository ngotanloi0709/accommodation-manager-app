using AccommodationManagerApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BillModel = AccommodationManagerApp.Model.Bill;
namespace AccommodationManagerApp.Forms
{
    public partial class ClientForm
    {
        private BillModel _bill;
        private BillModel SelectBill()
        {
            if (ListViewBill.SelectedItems.Count > 0)
            {
                var index = ListViewBill.SelectedItems[0].Index;

                if (index < _Bills.Count) return _Bills[index];
            }
            return null;
        }
        private void InsertBillIntoListView(List<BillModel> bills)
        {
            ListViewBill.Items.Clear();
            foreach (var bill in bills)
            {
                var item = new ListViewItem(bill.Id.ToString());
                item.SubItems.Add(bill.ElectricityQuantity.ToString());
                item.SubItems.Add(bill.WaterQuantity.ToString());
                item.SubItems.Add(bill.Contract?.Room.RoomNumber.ToString() ?? "Trống");
                item.SubItems.Add(bill.User.Name);
                item.SubItems.Add(bill.DateOfBillFormatted);
                item.SubItems.Add(bill.Status.ToVietnamese());
                ListViewBill.Items.Add(item);
            }
        }
        private void buttonPreview_Click(object sender, System.EventArgs e)
        {
            var confirmForm = new ConfirmationForm("Bạn muốn xem chi tiết hóa đơn ?");
            confirmForm.ShowDialog();
            
            if (confirmForm.DialogResult != DialogResult.Yes) return;
            
            _bill = SelectBill();
            if (_bill == null)
            {
                new ToastForm("Mời chọn hóa đơn để xem chi tiết", true).Show();
                return;
            }

            var billDetail = new BillDetail(_bill);
            billDetail.ShowDialog();
        }

        // Query System
        private void LoadBillData()
        {
            _Bills = _billService.GetAllByUserIdWithContractWithRoomAndUser(_user.Id);
            InsertBillIntoListView(_Bills);
        }

        private void ComboBoxCatg_SelectedIndexChanged(object sender, EventArgs e)
        {
            int queryRouter;
            queryRouter = comboBoxCatg.SelectedIndex;
            switch (queryRouter)
            {
                case 0:
                    LoadBillData();
                    SetUpComboBoxVolumn(new List<string> { "Mức độ" });
                    break;
                case 1:
                    SetUpComboBoxVolumn(new List<string> { "Chưa Thanh Toán", "Đã Thanh Toán" });
                    break;
                case 2:
                    SetUpComboBoxVolumn(new List<string> { "Tháng này", "Tháng Sau", "Tháng Trước" });
                    break;
                case 3:
                    SetUpComboBoxVolumn(new List<string> { "Tăng", "Giảm" });
                    break;
            }
        }

        private void SetUpComboBoxVolumn(List<string> volumn)
        {
            comboBoxVolumn.Items.Clear();
            comboBoxVolumn.Items.AddRange(volumn.ToArray());
            comboBoxVolumn.SelectedIndex = 0;
        }
    }
}


