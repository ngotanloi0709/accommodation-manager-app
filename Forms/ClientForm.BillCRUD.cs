using AccommodationManagerApp.Forms.Bill;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class ClientForm
    {
        private void addBill(object sender, System.EventArgs e)
        {
            AddBill addBill = new AddBill();
            addBill.ShowDialog();
            reset();

        }
        private void readBill()
        {
            Bills = _billService.GetAll();
            lstViewBill.Items.Clear();
            foreach (var bill in Bills)
            {
                var item = new ListViewItem(bill.Id.ToString());
                item.SubItems.Add(bill.RentBill.ToString());
                item.SubItems.Add(bill.WaterBill.ToString());
                item.SubItems.Add(bill.ElectricityBill.ToString());
                item.SubItems.Add(bill.TotalBill.ToString());
                item.SubItems.Add(bill.RoomId.ToString());
                item.SubItems.Add(bill.CreatedAtFormatted);
                item.SubItems.Add(bill.Status.ToString());
                lstViewBill.Items.Add(item);
            }
        }
        private void updateBill(object sender, System.EventArgs e)
        {
            if (billId != 0)
            {
                UpdateBill updateBill = new UpdateBill(billId);
                updateBill.ShowDialog();
                reset();
            }
            else
            {
                new ToastForm("Please select bill !", true).Show();
                return;
            }
        }
        private void deleteBill(object sender, System.EventArgs e)
        {
            if (billId != 0)
            {
                var confirmation = new ConfirmationForm("Xác nhận xóa phương tiện?");
                var result = confirmation.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    _billService.Delete(billId);
                    reset();
                }
            }
            else
            {
                new ToastForm("Please select bill !", true).Show();
                return;
            }
        }
    }
}
