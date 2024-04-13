using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
using AccommodationManagerApp.Service;

namespace AccommodationManagerApp.Forms {
    public partial class CurrentUserInformationForm : BaseForm {
        private User _user;
        private readonly UserService _userService;
        
        public CurrentUserInformationForm(User user) {
            InitializeComponent();
            
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;
            _user = user;
            
            if (_user == null)
            {
                new ToastForm("Đã có lỗi xảy ra!", true);
                Close();
            }
            
            SetUpData(_user);
        }

        private void SetUpData(User user) {
            LoadAvatar(user);

            labelUserName.Text = string.IsNullOrEmpty(user.Name) ? Resources.NullData : user.Name;
            labelUserPhone.Text = string.IsNullOrEmpty(user.Phone) ? Resources.NullData : user.Phone;
            labelUserIdentityNumber.Text = string.IsNullOrEmpty(user.IdentityNumber)
                ? Resources.NullData
                : user.IdentityNumber;
            labelUserSex.Text = user.IsFemale ? "Nữ" : "Nam";
            labelUserDateOfBirth.Text = string.IsNullOrEmpty(user.DateOfBirth.ToString())
                ? Resources.NullData
                : user.DateOfBirth.ToString("dd/MM/yyyy");
            labelUserEmail.Text = string.IsNullOrEmpty(user.Email) ? Resources.NullData : user.Email;
        }

        private void LoadAvatar(User user) {
            try {
                if (user.Avatar != null) {
                    using (var ms = new MemoryStream(user.Avatar)) {
                        pictureBoxUserImage.Image = Image.FromStream(ms);
                    }
                }
                else {
                    pictureBoxUserImage.Image = Resources.user;
                }
            }
            catch (Exception e) {
                pictureBoxUserImage.Image = Resources.user;
                Console.WriteLine(e);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e) {
            var userForm = new UserForm(_user, true);
            userForm.ShowDialog();
            
            if (userForm.DialogResult == DialogResult.Cancel) {
                return;
            }
            
            if (userForm.DialogResult == DialogResult.OK) {
                SetUpData(_user);
                new ToastForm("Cập nhật thành công").Show();
            }
        }

        private void buttonEditAvatar_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog {
                Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                var image = Image.FromFile(openFileDialog.FileName);
                var compressedImage = _userService.CompressImage(image, 50);

                using (var ms = new MemoryStream()) {
                    compressedImage.Save(ms, image.RawFormat);
                    _user.Avatar = ms.ToArray();
                }
                    
                var updateResult = _userService.Update(_user.Id, _user);
                if (updateResult) {
                    LoadAvatar(_user);
                    new ToastForm("Cập nhật thành công", false).Show();
                }
                else {
                    new ToastForm("Cập nhật thất bại", true).Show();
                }
            }
        }

        private void buttonEditPassword_Click(object sender, EventArgs e)
        {
            var changeUserPasswordForm = new ChangeUserPasswordForm(_user);
            changeUserPasswordForm.Show();
        }
    }
}