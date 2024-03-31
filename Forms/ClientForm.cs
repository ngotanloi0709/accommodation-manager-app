using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;
using AccommodationManagerApp.Service;
using System.Collections.Generic;
using BillModel = AccommodationManagerApp.Model.Bill;
namespace AccommodationManagerApp.Forms
{
    public partial class ClientForm : BaseForm
    {
        private readonly BillService _billService;
        private readonly AuthenticationService _authenticationService;
        private readonly RequestService _requestService;
        
        private User user;
        private List<Request> requests;

        private List<BillModel> Bills { get; set; }
        public ClientForm()
        {
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _requestService = ServiceLocator.ServiceProvider.GetService(typeof(RequestService)) as RequestService;
            user = _authenticationService.CurrentUser;
            InitializeComponent();
            setInfor();
            load();
        }

        private void load()
        {
            readBill();
            readReq();
        }

        private void setInfor()
        {
            if (_authenticationService.IsAuthenticated())
            {
                lblEmail.Text = _authenticationService.CurrentUser.Email;
            } else
            {
                lblEmail.Text = defaultMail;
                btnLogin.Visible = true;
            }
        }
        private void showInfor(object sender, System.EventArgs e)
        {
            if (_authenticationService.IsAuthenticated())
            {
                CurrentUserInformationForm userManagementForm = new CurrentUserInformationForm(_authenticationService.CurrentUser);
                userManagementForm.ShowDialog();
            }
            else
            {
                new ToastForm("Vui lòng đăng nhập để sử dụng chức năng này", true).Show();
            }
        }
    }
}
