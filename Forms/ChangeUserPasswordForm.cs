using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms
{
    public partial class ChangeUserPasswordForm : BaseForm
    {
        private User _user;
        private readonly UserService _userService;

        public ChangeUserPasswordForm(User user)
        {
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;
            _user = user;
            InitializeComponent();

            if (_user == null)
            {
                new ToastForm("Đã có lỗi xảy ra!", true);
            }
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (!IsAllTextBoxFilled() || !IsPasswordMatch())
            {
                return;
            }

            _user.Password = PasswordHelper.HashPassword(textBoxPassword.Text);
            if (_userService.Update(_user.Id, _user)) {
                new ToastForm("Sửa mật khẩu thành công").Show();
                Close();
            }
            else {
                new ToastForm("Sửa mật khẩu thất bại", true).Show();
            }
        }

        private bool IsPasswordMatch() {
            if (textBoxPassword.Text != textBoxConfirmPassword.Text) {
                new ToastForm("Mật khẩu không khớp. Vui lòng nhập lại.", true).Show();
                return false;
            }

            return true;
        }

        private bool IsAllTextBoxFilled() {
            var result = string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrEmpty(textBoxConfirmPassword.Text);
            
            if (result) {
                new ToastForm("Vui lòng điền đầy đủ các trường.", true).Show();
            }

            return !result;
        }
    }
}