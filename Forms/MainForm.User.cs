using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm {
        private void LoadUserData() {
            ListViewUser.Items.Clear();
            Users = _userService.GetAllWithRoom();

            foreach (var user in Users) {
                ListViewItem item = new ListViewItem(user.Name);
                item.SubItems.Add(user.Phone);
                item.SubItems.Add(user.IdentityNumber);
                ListViewUser.Items.Add(item);
            }
        }

        private void ListViewUser_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            User user = IsSelectedUserValid();

            if (user != null) {
                LoadTenantAvatar(user);

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

                ListViewUserRentList.Items.Clear();
                foreach (var room in user.Rooms) {
                    ListViewItem item = new ListViewItem(string.IsNullOrEmpty(room.RoomNumber)
                        ? Resources.NullData
                        : room.RoomNumber);
                    item.SubItems.Add(room.Building == null || string.IsNullOrEmpty(room.Building.Name)
                        ? Resources.NullData
                        : room.Building.Name);
                    ListViewUserRentList.Items.Add(item);
                }
            }
        }

        private void buttonAddTenant_Click(object sender, System.EventArgs e) {
            var userForm = new UserForm(null);
            userForm.ShowDialog();
            ShowUserDialogMessageResult(userForm.DialogResult, false);
        }

        private void buttonEditTenant_Click(object sender, System.EventArgs e) {
            User user = IsSelectedUserValid();

            if (user != null) {
                var userForm = new UserForm(user);
                userForm.ShowDialog();
                ShowUserDialogMessageResult(userForm.DialogResult, true);
                SelectUserAgain(user);
            }
            else {
                new ToastForm("Vui lòng chọn người thuê cần sửa", true).Show();
            }
        }

        private void ShowUserDialogMessageResult(DialogResult dialogResult, bool isEdit) {
            string message;
            if (dialogResult == DialogResult.Cancel) {
                return;
            }

            if (dialogResult == DialogResult.OK) {
                if (isEdit) {
                    UserForeignInformationReload();
                }
                else {
                    LoadUserData();
                }

                message = isEdit
                    ? "Sửa thông tin người thuê thành công"
                    : "Thêm thông tin người thuê thành công";
            }
            else {
                message = isEdit ? "Sửa thông tin người thuê thất bại" : "Thêm thông tin người thuê thất bại";
            }

            new ToastForm(message, dialogResult != DialogResult.OK).Show();
        }

        private void buttonDeleteTenant_Click(object sender, System.EventArgs e) {
            User user = IsSelectedUserValid();
            if (user != null) {
                var confirmationForm = new ConfirmationForm("Bạn có chắc chắn muốn xóa người thuê này không?");
                var result = confirmationForm.ShowDialog();
                if (result == DialogResult.Yes) {
                    var deleteResult = _userService.Delete(user.Id);
                    if (deleteResult) {
                        UserForeignInformationReload();
                        new ToastForm("Xóa thông tin người thuê thành công", false).Show();
                    }
                    else {
                        new ToastForm("Xóa thông tin người thuê thất bại", true).Show();
                    }
                }
            }
            else {
                new ToastForm("Vui lòng chọn người thuê cần xóa", true).Show();
            }
        }

        private void buttonEditTenantPassword_Click(object sender, System.EventArgs e) {
            User user = IsSelectedUserValid();
            
            if (user != null) {
                var changeUserPasswordForm = new ChangeUserPasswordForm(user);
                changeUserPasswordForm.Show();
            }
            else {
                new ToastForm("Vui lòng chọn người thuê cần sửa mật khẩu", true).Show();
            }
        }

        private void buttonChangeTenantAvatar_Click(object sender, EventArgs e) {
            User user = IsSelectedUserValid();
            if (user != null) {
                OpenFileDialog openFileDialog = new OpenFileDialog {
                    Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG",
                    RestoreDirectory = true
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    Image image = Image.FromFile(openFileDialog.FileName);
                    Image compressedImage = _userService.CompressImage(image, 50);

                    using (MemoryStream ms = new MemoryStream()) {
                        compressedImage.Save(ms, image.RawFormat);
                        user.Avatar = ms.ToArray();
                    }
                    
                    var updateResult = _userService.Update(user.Id, user);
                    if (updateResult) {
                        LoadTenantAvatar(user);
                        new ToastForm("Cập nhật thành công", false).Show();
                    }
                    else {
                        new ToastForm("Cập nhật thất bại", true).Show();
                    }
                }
            }
            else {
                new ToastForm("Xin hãy chọn người thuê cần cập nhật hình ảnh", true).Show();
            }
        }

        private void LoadTenantAvatar(User user) {
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

        private User IsSelectedUserValid() {
            if (ListViewUser.SelectedItems.Count > 0) {
                int index = ListViewUser.SelectedItems[0].Index;
                if (index < Users.Count) {
                    return Users[index];
                }
            }

            return null;
        }

        private void SelectUserAgain(User user) {
            int index = Users.IndexOf(user);

            if (ListViewUser.Items.Count > index) {
                ListViewUser.Items[index].Selected = true;
                ListViewUser.Select();
            }
        }

        private void UserForeignInformationReload() {
            LoadUserData();
            LoadRoomData();
        }
    }
}