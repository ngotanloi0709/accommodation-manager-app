using System.Windows.Forms;
using System.Threading;


namespace AccommodationManagerApp.Forms
{
    public partial class MainForm
    {
        private void logout(object sender, System.EventArgs e)
        {
            var confirmation = new ConfirmationForm("Bạn có chắc chắn muốn thoát");
            var result = confirmation.ShowDialog();
            if (result == DialogResult.Yes)
            {
                _authenticationService.Logout();
                LoadPersonalInformation();
            }
        }
        private void login(object sender, System.EventArgs e)
        {
            var confirmation = new ConfirmationForm("Bạn có chắc chắn muốn đăng xuất");
            var result = confirmation.ShowDialog();
            if (result == DialogResult.Yes)
            {
                _authenticationService.Logout();
                Close();

                Thread loginFormThread = new Thread(() =>
                {
                    Application.SetCompatibleTextRenderingDefault(false);
                    LoginForm loginForm = new LoginForm();
                    Application.Run(loginForm);
                });

                loginFormThread.SetApartmentState(ApartmentState.STA);
                loginFormThread.Start();
            }
        }
    }
}
