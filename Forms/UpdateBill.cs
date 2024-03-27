using BillService = AccommodationManagerApp.Service.BillService;
using ServiceLocator = AccommodationManagerApp.Service.ServiceLocator;
using BillModel = AccommodationManagerApp.Model.Bill;
using AccommodationManagerApp.Model;
using System.Windows.Forms;
namespace AccommodationManagerApp.Forms.Bill
{
    public partial class UpdateBill : BillForm
    {
        private int id;
        private BillModel preBill, postBill;
        private readonly BillService _billService;
        public UpdateBill(int id)
        {
            InitializeComponent();
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            this.id = id;
            preBill = _billService.GetById(id);
            loadData();
        }

        private void loadData()
        {
            lblDate.Text += preBill.CreatedAtFormatted;
            cmbboxRent.Text = preBill.RentBill.ToString();
            txtbxWater.Text = preBill.WaterBill.ToString();
            txtbxElectric.Text = preBill.ElectricityBill.ToString();
        }
        private void update(object sender, System.EventArgs e)
        {
            MessageBox.Show(id.ToString());
            postBill = setBill();
            if (postBill != null)
            {
                _billService.Update(id, postBill);
                new ToastForm("Update Success!", false).Show();
                this.Close();
            } else
            {
                new ToastForm("Please Complete Information!").Show();
            }
        }
    }
}
