using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;
using AccommodationManagerApp.Service;
using System.Collections.Generic;
using BillModel = AccommodationManagerApp.Model.Bill;
using System.Windows.Forms;
namespace AccommodationManagerApp.Forms
{
    public partial class ClientForm : BaseForm
    {
        private BillService _billService;
        private RequestService _requestService;
        private AuthenticationService _authenticationService;

        private User _user;
        private List<Request> _Requests;
        private List<BillModel> _Bills;
        public ClientForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadService();
            LoadEntity();
            LoadBillData();
            LoadRequestData();
            LoadPersonalInformation();
        }

        private void LoadEntity() 
        {
            _user = _authenticationService.CurrentUser;
            labelWaterPrice.Text = _billService.GetWaterPrice().Price.ToString();
            labelElectricityPrice.Text = _billService.GetElectricityPrice().Price.ToString();
            labelInternetPrice.Text = _billService.GetInternetPrice().Price.ToString();
        }
        private void LoadService()
        {
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _requestService = ServiceLocator.ServiceProvider.GetService(typeof(RequestService)) as RequestService;
        }

        private void LoadPersonalInformation()
        {
            lblEmail.Text = _authenticationService.IsAuthenticated() ? _authenticationService.CurrentUser.Email : defaultMail;
        }
        private void ShowInfor(object sender, System.EventArgs e)
        {
            if (_authenticationService.IsAuthenticated())
            {
                var userManagementForm = new CurrentUserInformationForm(_authenticationService.CurrentUser);
                userManagementForm.ShowDialog();
            }
            else
            {
                new ToastForm("Vui lòng đăng nhập để sử dụng chức năng này", true).Show();
            }
        }

        private void Logout(object sender, System.EventArgs e)
        {
            var confirmation = new ConfirmationForm("Bạn có muốn đăng xuất");
            var result = confirmation.ShowDialog();
            if (result == DialogResult.Yes)
            {
                _authenticationService.Logout();
                Close();
            }
        }
    }
}
