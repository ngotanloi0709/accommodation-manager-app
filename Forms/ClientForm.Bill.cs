using System.Windows.Forms;
using BillModel = AccommodationManagerApp.Model.Bill;
namespace AccommodationManagerApp.Forms
{
    public partial class ClientForm
    {
        private BillModel _bill;
        private BillModel SelectBill()
        {
            if (lstViewBill.SelectedItems.Count > 0)
            {
                var index = lstViewBill.SelectedItems[0].Index;

                if (index < _Bills.Count) return _Bills[index];
            }
            return null;
        }
        private void LoadBillData()
        {

            _Bills = _billService.GetAllBillByUserId(_user.Id);
            lstViewBill.Items.Clear();
            foreach (var bill in _Bills)
            {
                var item = new ListViewItem(bill.Id.ToString());
                item.SubItems.Add(bill.ElecQuantity.ToString());
                item.SubItems.Add(bill.WaterQuantity.ToString());
                item.SubItems.Add(bill.Contract?.Room.RoomNumber.ToString() ?? "Trống");
                item.SubItems.Add(bill.CreatedAtFormatted);
                item.SubItems.Add(bill.Status.ToString());
                lstViewBill.Items.Add(item);
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
    }
}


