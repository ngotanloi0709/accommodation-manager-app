using BillModel = AccommodationManagerApp.Model.Bill;
using AccommodationManagerApp.Service;

namespace AccommodationManagerApp.Forms.Bill
{
    public partial class AddBill : BillForm
    {
        private readonly BillService _billService;
        public AddBill()
        {
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            InitializeComponent();
        }

        private void add(object sender, System.EventArgs e)
        {
            BillModel bill = setBill();
            if (bill != null)
            {
                _billService.Add(bill);
                new ToastForm("Add Success!", false).Show();
                this.Close();
            }
            new ToastForm("Please Complete Information!").Show();
        }
    }
}
