using AccommodationManagerApp.Repository;
using AccommodationManagerApp.Service;
using AuthenticationServce = AccommodationManagerApp.Service.AuthenticationService;

namespace AccommodationManagerApp.Forms
{
    public partial class AdminForm : BaseForm
    {
        private readonly AuthenticationServce _authenticationService;
        public AdminForm()
        {
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            InitializeComponent();
            renderPersonalInformation();
        }

        private void buttonCurrentUserInformationManagement_Click(object sender, System.EventArgs e)
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
        private void renderPersonalInformation()
        {
            if (_authenticationService.IsAuthenticated())
            {
                labelAdminEmail.Text = _authenticationService.CurrentUser.Email;
            }
            else
            {
                labelAdminEmail.Text = defaultMail;
                buttonAdminLogin.Visible = true;
            }
        }
    }
}
