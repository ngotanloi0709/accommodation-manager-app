using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm {
        private void LoadSystemUserData() {
            ListViewSystemUser.Items.Clear();
            SystemUsers = _userService.GetAllWithRoleNotTenantAndWithContractAndRoom();

            foreach (var user in SystemUsers) {
                var item = new ListViewItem(string.IsNullOrEmpty(user.Name) ? Resources.NullData : user.Name);
                item.SubItems.Add(string.IsNullOrEmpty(user.Phone) ? Resources.NullData : user.Phone);
                item.SubItems.Add(string.IsNullOrEmpty(user.IdentityNumber) ? Resources.NullData : user.IdentityNumber);
                item.SubItems.Add(user.DateOfBirth.ToString("dd/MM/yyyy"));
                item.SubItems.Add(string.IsNullOrEmpty(user.Email) ? Resources.NullData : user.Email);
                item.SubItems.Add(user.IsFemale ? "Nữ" : "Nam");
                item.SubItems.Add(user.Role.ToVietnamese());
                ListViewSystemUser.Items.Add(item);
            }
        }
        
        private void ListViewSystemUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user = IsSelectedSystemUserValid();

            if (user != null) {
                LoadSystemUserAvatar(user);

                LabelSystemUserName.Text = string.IsNullOrEmpty(user.Name) ? Resources.NullData : user.Name;
                LabelSystemUserPhone.Text = string.IsNullOrEmpty(user.Phone) ? Resources.NullData : user.Phone;
                LabelSystemUserIdentity.Text = string.IsNullOrEmpty(user.IdentityNumber)
                    ? Resources.NullData
                    : user.IdentityNumber;
                LabelSystemUserGender.Text = user.IsFemale ? "Nữ" : "Nam";
                LabelSystemUserDateOfBirth.Text = string.IsNullOrEmpty(user.DateOfBirth.ToString(CultureInfo.CurrentCulture))
                    ? Resources.NullData
                    : user.DateOfBirth.ToString("dd/MM/yyyy");
                LabelSystemUserEmail.Text = string.IsNullOrEmpty(user.Email) ? Resources.NullData : user.Email;
                LabelSystemUserRole.Text = user.Role.ToVietnamese();
            }
        }
        
        private User IsSelectedSystemUserValid() {
            if (ListViewSystemUser.SelectedItems.Count > 0) {
                var index = ListViewSystemUser.SelectedItems[0].Index;
                if (index < SystemUsers.Count) {
                    return SystemUsers[index];
                }
            }

            return null;
        }
        
        private void LoadSystemUserAvatar(User user) {
            try {
                if (user.Avatar != null) {
                    using (var ms = new MemoryStream(user.Avatar)) {
                        pictureBoxSystemUserAvatar.Image = Image.FromStream(ms);
                    }
                }
                else {
                    pictureBoxSystemUserAvatar.Image = Resources.user;
                }
            }
            catch (Exception e) {
                pictureBoxSystemUserAvatar.Image = Resources.user;
                Console.WriteLine(e);
            }
        }
        
        private void ButtonSystemUserAdd_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm(null, false, true);
            userForm.ShowDialog();
            ShowSystemUserDialogMessageResult(userForm.DialogResult, false);
        }

        private void ButtonSystemUserEdit_Click(object sender, EventArgs e)
        {
            var user = IsSelectedSystemUserValid();

            if (user != null) {
                var userForm = new UserForm(user, false, true);
                userForm.ShowDialog();
                ShowSystemUserDialogMessageResult(userForm.DialogResult, true);
                SelectSystemUserAgain(user);
            }
            else {
                new ToastForm("Vui lòng chọn người quản trị cần sửa", true).Show();
            }
        }
        
        private void ShowSystemUserDialogMessageResult(DialogResult dialogResult, bool isEdit) {
            string message;
            if (dialogResult == DialogResult.Cancel) {
                return;
            }

            if (dialogResult == DialogResult.OK) {
                if (isEdit) {
                    SystemUserForeignInformationReload();
                }
                else {
                    LoadSystemUserData();
                }

                message = isEdit
                    ? "Sửa thông tin người quản trị thành công"
                    : "Thêm thông tin người quản trị thành công";
            }
            else {
                message = isEdit ? "Sửa thông tin người quản trị thất bại" : "Thêm thông tin người quản trị thất bại";
            }

            new ToastForm(message, dialogResult != DialogResult.OK).Show();
        }
        
        private void SelectSystemUserAgain(User user) {
            var index = SystemUsers.IndexOf(user);

            if (ListViewSystemUser.Items.Count > index) {
                ListViewSystemUser.Items[index].Selected = true;
                ListViewSystemUser.Select();
            }
        }
        
        private void SystemUserForeignInformationReload() {
            LoadSystemUserData();
        }

        private void ButtonSystemUserDelete_Click(object sender, EventArgs e)
        {
            var user = IsSelectedSystemUserValid();
            if (user != null) {
                var confirmationForm = new ConfirmationForm("Bạn có chắc chắn muốn xóa người quản trị này không?");
                var result = confirmationForm.ShowDialog();
                
                if (result == DialogResult.Yes) {
                    var deleteResult = _userService.Delete(user.Id);
                    if (deleteResult) {
                        SystemUserForeignInformationReload();
                        new ToastForm("Xóa thông tin người quản trị thành công").Show();
                    }
                    else {
                        new ToastForm("Xóa thông tin người quản trị thất bại", true).Show();
                    }
                }
            }
            else {
                new ToastForm("Vui lòng chọn người quản trị cần xóa", true).Show();
            }
        }

        private void ButtonSystemUserChangeAvatar_Click(object sender, EventArgs e)
        {
            var user = IsSelectedSystemUserValid();
            if (user != null) {
                var openFileDialog = new OpenFileDialog {
                    Filter = Resources.ImageFilter,
                    RestoreDirectory = true
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    var image = Image.FromFile(openFileDialog.FileName);
                    var compressedImage = _userService.CompressImage(image, 50);

                    using (var ms = new MemoryStream()) {
                        compressedImage.Save(ms, image.RawFormat);
                        user.Avatar = ms.ToArray();
                    }

                    var updateResult = _userService.Update(user.Id, user);
                    if (updateResult) {
                        LoadSystemUserAvatar(user);;
                        new ToastForm("Cập nhật thành công").Show();
                    }
                    else {
                        new ToastForm("Cập nhật thất bại", true).Show();
                    }
                }
            }
            else {
                new ToastForm("Xin hãy chọn người quản trị cần cập nhật hình ảnh", true).Show();
            }
        }

        private void ButtonSystemUserChangePassword_Click(object sender, EventArgs e)
        {
            var user = IsSelectedSystemUserValid();

            if (user != null) {
                var changeUserPasswordForm = new ChangeUserPasswordForm(user);
                changeUserPasswordForm.Show();
            }
            else {
                new ToastForm("Vui lòng chọn người quản trị cần sửa mật khẩu", true).Show();
            }
        }

        private void ButtonReloadSystemUser_Click(object sender, EventArgs e)
        {
            LoadSystemUserData();
            new ToastForm("Đã thực hiện tải dữ liệu quản trị viên").Show();
        }
    }
}