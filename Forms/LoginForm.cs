using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;
using System;
using System.Threading;
using System.Windows.Forms;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Forms
{
    public partial class LoginForm : BaseForm
    {
        private readonly AuthenticationService _authenticationService;

        public LoginForm()
        {
            InitializeComponent();

            _authenticationService =
                ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
        }

        private void Login(object sender, EventArgs e)
        {
            var email = txtEmail1.Text;
            var password = txtPass1.Text;

            if (!InputHelper.IsValidInputEmail(email))
            {
                new ToastForm("Vui lòng nhập email hợp lệ", true).Show();
                return;
            }

            var result = _authenticationService.Authenticate(email, password);

            if (!result)
            {
                new ToastForm("Đăng Nhập Sai Thông Tin !!!", true).Show();
                return;
            }

            Dispose();
            // Hide();

            var thread = new Thread(() => { Application.Run(new SplashForm()); });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void Logout(object sender, EventArgs e)
        {
            var confirm = new ConfirmationForm("Bạn chắc muốn thoát chứ");
            var result = confirm.ShowDialog();
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}