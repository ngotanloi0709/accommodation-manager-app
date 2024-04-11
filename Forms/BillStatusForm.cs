using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class BillStatusForm : BaseForm
    {
        private Bill _bill;
        private readonly BillService _billService;

        public BillStatusForm(Bill bill)
        {
            InitializeComponent();
            
            _bill = bill;
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;

            SetUpComboBox();
            SetUpData();
        }

        private void SetUpComboBox()
        {
            ComboBoxBillStatus.Items.Add(BillStatus.Edit.ToVietnamese());
            ComboBoxBillStatus.Items.Add(BillStatus.Unpaid.ToVietnamese());
            ComboBoxBillStatus.Items.Add(BillStatus.Paid.ToVietnamese());
            ComboBoxBillStatus.SelectedIndex = 0;
        }

        private void SetUpData()
        {
            LabelBillId.Text = _bill.Id.ToString();
            LabelRoomNumber.Text = _bill.Contract.Room.RoomNumber;
            LabelRoomTenant.Text = _bill.Contract.User.Name;
            LabelBillTotal.Text = _bill.GetTotalPrice().ToString();
            LabelBillOfMonth.Text = _bill.DateOfBill.Month.ToString();
            ComboBoxBillStatus.SelectedItem = _bill.Status.ToVietnamese();
        }

        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            _bill.Status = ComboBoxBillStatus.SelectedItem.ToString().ToBillStatus();
            _billService.Update(_bill.Id, _bill);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BillStatusForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}