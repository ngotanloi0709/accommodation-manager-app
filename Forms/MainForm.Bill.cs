using AccommodationManagerApp.Forms.Bill;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class MainForm
    {
        private int billId = 0;
        private void LoadBillData()
        {
            // btnPDF.Enabled = billId != 0;
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
                item.SubItems.Add(bill.CreatedAt.ToString());
                item.SubItems.Add(bill.Status.ToString());
                lstViewBill.Items.Add(item);
            }
        }
        private void LstViewBill_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.Selected)
            {
                billId = int.Parse(e.Item.SubItems[0].Text);
            }
        }
        private void BtnPDF_Click(object sender, System.EventArgs e)
        {
            if (billId == 0)
            {
                new ToastForm("Please select a bill to export to PDF", true).Show();
                return;
            }

            BillDetail billDetail = new BillDetail(billId);
            billDetail.ShowDialog();
        }
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AddBill addBill = new AddBill();
            addBill.ShowDialog();
            reset();

        }
        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (billId != 0)
            {
                if ((new ConfirmationForm("Do you want to delete this bill ?")).ShowDialog() == DialogResult.Yes)
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
        private void btnUpd_Click(object sender, System.EventArgs e)
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
        private void reset()
        {
            billId = 0;
            LoadBillData();
        }
    }
}


