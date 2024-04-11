using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class UserForm : BaseForm
    {
        private User _user;
        private readonly UserService _userService;

        public UserForm(User user, bool isCurrentUser = false)
        {
            InitializeComponent();
            
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;
            _user = user;

            if (_user != null)
            {
                SetUpData(_user);
                Text = isCurrentUser ? "Chỉnh sửa thông tin cá nhân" : "Chỉnh sửa thông tin người dùng";
            }
        }

        private void SetUpData(User user)
        {
            textBoxName.Text = user.Name;
            textBoxPhone.Text = user.Phone;
            textBoxEmail.Text = user.Email;
            textBoxIdentityNumber.Text = user.IdentityNumber;
            switchSex.Checked = user.IsFemale;
            dateTimePickerDateOfBirth.Value = user.DateOfBirth;
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (!IsAllTextBoxFilled() || !IsEmailSafe()) return;

            if (_user == null)
            {
                _user = new User(
                    textBoxEmail.Text,
                    textBoxName.Text,
                    PasswordHelper.HashPassword("123"),
                    switchSex.Checked,
                    textBoxPhone.Text,
                    textBoxIdentityNumber.Text,
                    dateTimePickerDateOfBirth.Value);

                _userService.Add(_user);
            }
            else
            {
                _user.Name = textBoxName.Text;
                _user.Phone = textBoxPhone.Text;
                _user.Email = textBoxEmail.Text;
                _user.IdentityNumber = textBoxIdentityNumber.Text;
                _user.IsFemale = switchSex.Checked;
                _user.DateOfBirth = dateTimePickerDateOfBirth.Value;

                _userService.Update(_user.Id, _user);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool IsEmailSafe()
        {
            if ((_user == null || _user.Email != textBoxEmail.Text) &&
                _userService.IsEmailExists(textBoxEmail.Text))
            {
                new ToastForm("Email đã tồn tại. Vui lòng nhập Email khác.", true).Show();
                return false;
            }

            return true;
        }

        private bool IsAllTextBoxFilled()
        {
            var result = string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxEmail.Text);

            if (result)
            {
                new ToastForm("Vui lòng điền đầy đủ thông tin.", true).Show();
            }
            
            if (!InputHelper.IsValidInputNumber(textBoxIdentityNumber.Text))
            {
                new ToastForm("Vui lòng nhập số chứng minh/căn cước hợp lệ", true).Show();
                return false;
            }
            
            if (!InputHelper.IsValidInputNumber(textBoxPhone.Text))
            {
                new ToastForm("Vui lòng nhập số điện thoại hợp lệ", true).Show();
                return false;
            }
            
            if (!InputHelper.IsValidInputEmail(textBoxEmail.Text))
            {
                new ToastForm("Vui lòng nhập Email hợp lệ", true).Show();
                return false;
            }

            return !result;
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}