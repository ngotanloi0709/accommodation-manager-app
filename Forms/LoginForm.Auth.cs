using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class LoginForm
    {
        private void login(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPass.Text;
            try
            {
                bool result = _authenticationService.Authenticate(email, password);
                if (result)
                {
                    SplashForm splashForm = new SplashForm();
                    splashForm.Show();
                    this.Hide();
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
                this.Close();
            }
        }
    }
}
