using AccommodationManagerApp.Repository;
using AccommodationManagerApp.Service;
using System.Threading;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class ClientForm : BaseForm
    {
        private readonly AuthenticationService _authenticationService;
        public ClientForm()
        {
            InitializeComponent();
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            setInfor();
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
