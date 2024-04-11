using AccommodationManagerApp.Service;
using System.Windows.Forms;
using System;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms
{
    public partial class LoginForm : BaseForm
    {
        private readonly AuthenticationService _authenticationService;

        public LoginForm()
        {
            InitializeComponent();

            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
        }
        
        private void Login(object sender, EventArgs e) 
        {
            var email = txtEmail.Text;
            var password = txtPass.Text;

            if (!InputHelper.IsValidInputEmail(email)) 
            {
                new ToastForm("Vui lòng nhập email hợp lệ", true).Show();
                return;
            }


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

        private void Logout(object sender, EventArgs e)
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