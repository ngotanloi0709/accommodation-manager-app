using AccommodationManagerApp.Forms.Bill;
using System.Windows.Forms;
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
                int index = lstViewBill.SelectedItems[0].Index;
                
                if(index < Bills.Count) return Bills[index];
            }
            return null;
        }
        private void previewBill(object sender, System.EventArgs e)
        {
            _bill = SelectBill();
            if (_bill == null)
            {
                new ToastForm("Mời chọn hóa đơn để xem chi tiết", true).Show();
                return;
            }

            BillDetail billDetail = new BillDetail(_bill);
            billDetail.ShowDialog();
        }
        private void InsertBill(BillModel bill)
        {
            BillForm billForm = new BillForm(bill);
            billForm.ShowDialog();
            LoadBillData();
        }
        private void addBill(object sender, System.EventArgs e)
        {
            InsertBill(null);
            LoadFixedPriceToBills();
        }
        private void updateBill(object sender, System.EventArgs e)
        {
            _bill = SelectBill();
            if (_bill == null)
            {
                new ToastForm("Mời chọn hóa đơn !", true).Show();
                return;
            }
            InsertBill(_bill);
        }
        private void LoadBillData()
        {

            Bills = _billService.GetAll();
            lstViewBill.Items.Clear();
            foreach (var bill in Bills)
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
        private void deleteBill(object sender, System.EventArgs e)
        {
            _bill = SelectBill();
            if (_bill != null)
            {
                var confirmation = new ConfirmationForm("Xác nhận xóa hóa đơn?");
                var result = confirmation.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    _billService.Delete(_bill.Id);
                    LoadBillData();
                }
            }
            else
            {
                new ToastForm("Mời chọn hóa đơn để xóa !", true).Show();
                return;
            }
        }
        private void LoadFixedPriceToBills()
        {
            int waterFee = _billService.GetWaterPrice().Price;
            int elecFee = _billService.GetElectricityPrice().Price;
            int internetFee = _billService.GetInternetPrice().Price;

            foreach(var Bill in Bills)
            {
                if(Bill.InternetFee == 0 || Bill.ElecFee == 0 || Bill.WaterFee == 0)
                {
                    Bill.WaterFee = waterFee;
                    Bill.ElecFee = elecFee;
                    Bill.InternetFee = internetFee;
                    _billService.Update(Bill.Id, Bill);
                }
            }
        }
    
    }
}


