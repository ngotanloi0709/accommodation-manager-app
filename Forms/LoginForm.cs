using AccommodationManagerApp.Service;
using System.Windows.Forms;
using System;

namespace AccommodationManagerApp.Forms
{
    public partial class LoginForm : BaseForm
    {
        private readonly AuthenticationService _authenticationService;
        public LoginForm()
        {
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            InitializeComponent();
            btnExit.Visible = false;
        }
        private void login(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var password = txtPass.Text;
            try
            {
                var result = _authenticationService.Authenticate(email, password);
                if (result)
                {
                    var splashForm = new SplashForm();
                    splashForm.Show();
                    Hide();
                }
                else
                {
                    new ToastForm("Đăng Nhập Sai Thông Tin !!!", true).Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logout(object sender, EventArgs e)
        {
            var confirm = new ConfirmationForm("Bạn chắc muốn thoát chứ");
            var result = confirm.ShowDialog();
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

    }
}

