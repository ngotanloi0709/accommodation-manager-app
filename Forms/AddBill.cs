using BillModel = AccommodationManagerApp.Model.Bill;
using AccommodationManagerApp.Service;
using System;

namespace AccommodationManagerApp.Forms.Bill
{
    public partial class AddBill : BillForm
    {
        private readonly BillService _billService;
        public AddBill()
        {
            this.lblDate.Text += DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            InitializeComponent();
        }

        private void add(object sender, System.EventArgs e)
        {
            BillModel bill = setBill();
            if (bill != null)
            {
                _billService.Add(bill);
                new ToastForm("Thêm thành Công!", false).Show();
                this.Close();
            }
            new ToastForm("Xin bạn nhập đầy đủ thông tin!").Show();
        }
    }
}
