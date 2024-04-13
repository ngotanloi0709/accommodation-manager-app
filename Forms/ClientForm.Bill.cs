using AccommodationManagerApp.Model;
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
                item.SubItems.Add(FormatText.IntegerToVnd(bill.RentFee));
                item.SubItems.Add(bill.Contract?.Room.RoomNumber.ToString() ?? "Trống");
                item.SubItems.Add(bill.DateOfBillFormatted);
                item.SubItems.Add(QueryUtils.ToVietnamese(bill.Status));
                ListViewBill.Items.Add(item);
            }
        }
        private void ButtonPreview_Click(object sender, System.EventArgs e)
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

        private void LoadBillData()
        {
            _Bills = _billService.GetAllByUserIdWithContractWithRoomAndUser(_user.Id);
            InsertBillIntoListView(_Bills);
        }
        // Query System

        private void ListViewBill_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var bill = SelectBill();
            if (bill == null) return;
            LabelBillContractOwner.Text = bill.Contract.User.Name;
            LabelBillContractValue.Text = FormatText.IntegerToVnd(bill.Contract.Price);
            LabelBillTotal.Text = FormatText.IntegerToVnd(bill.GetTotalPrice());
            LabelBillRoomNumber.Text = bill.Contract.Room.RoomNumber;
            LabelBillContractEndDate.Text = bill.Contract.EndDate.ToString("dd/MM/yyyy");
        }
        private void ButtonPriceSearch_Click(object sender, EventArgs e)
        {
            BillStatus state = QueryUtils.ToBillStatus((string)comboBoxState.SelectedItem);
            List<object> time = QueryUtils.ChangeTextToDate((string)comboBoxTime.SelectedItem);
            List<string> text = new List<string> { null, null};
            int? minPrice = int.TryParse(textBoxMinPrice.Text, out int min) ? min : (int?)null;
            int? maxPrice = int.TryParse(textBoxMaxPrice.Text, out int max) ? max : (int?)null;

            if (QueryUtils.CheckMinMaxPrice(minPrice, maxPrice))
            {
                var queryBills = _billService.GetByCustomizeQuery(state, time, text, minPrice, maxPrice);
                InsertBillIntoListView(queryBills);
            }
            else
                new ToastForm("Xin mời nhập giá sàn thấp hơn giá trần", true).Show();
            return;
        }
    }
}


