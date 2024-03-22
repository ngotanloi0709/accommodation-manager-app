using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                MessageBox.Show("Please select a bill to export to PDF");
                return;
            }

            BillDetail billDetail = new BillDetail(billId);
            billDetail.ShowDialog();
        }
    }
}


