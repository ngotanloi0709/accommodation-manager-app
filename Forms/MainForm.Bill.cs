using AccommodationManagerApp.Forms.Bill;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class MainForm
    {
        private int billId = 0;
        private void LstViewBill_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.Selected)
            {
                billId = int.Parse(e.Item.SubItems[0].Text);
            }
        }
        private void pdfBill(object sender, System.EventArgs e)
        {
            if (billId == 0)
            {
                new ToastForm("Please select a bill to export to PDF", true).Show();
                return;
            }

            BillDetail billDetail = new BillDetail(billId);
            billDetail.ShowDialog();
        }
        private void reset()
        {
            billId = 0;
            readBill();
        }
    }
}


