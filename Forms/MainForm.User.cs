using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm {
        private void LoadUserData() {
            Users = _userService.GetAllWithRoleTenantAndWithContractAndRoom();
            InsertUserIntoListView(Users);
        }

        private void InsertUserIntoListView(List<User> users)
        {
            ListViewUser.Items.Clear();
            foreach (var user in users) {
                var item = new ListViewItem(string.IsNullOrEmpty(user.Name) ? Resources.NullData : user.Name);
                item.SubItems.Add(string.IsNullOrEmpty(user.Phone) ? Resources.NullData : user.Phone);
                item.SubItems.Add(string.IsNullOrEmpty(user.IdentityNumber) ? Resources.NullData : user.IdentityNumber);
                ListViewUser.Items.Add(item);
            }
        }

        private void LoadUserDataWithUnpaidBill() {
            ListViewUser.Items.Clear();
            Users = _userService.GetAllWithRoleTenantAndWithContractAndRoomWhereHasUnpaidBill();

            foreach (var user in Users) {
                var item = new ListViewItem(user.Name);
                item.SubItems.Add(user.Phone);
                item.SubItems.Add(user.IdentityNumber);
                ListViewUser.Items.Add(item);
            }
        }

        private void ListViewUser_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            var user = IsSelectedUserValid();

            if (user != null) {
                LoadTenantAvatar(user);
                MessageBox.Show(user.Id.ToString());
                labelUserName.Text = string.IsNullOrEmpty(user.Name) ? Resources.NullData : user.Name;
                labelUserPhone.Text = string.IsNullOrEmpty(user.Phone) ? Resources.NullData : user.Phone;
                labelUserIdentityNumber.Text = string.IsNullOrEmpty(user.IdentityNumber)
                    ? Resources.NullData
                    : user.IdentityNumber;
                labelUserSex.Text = user.IsFemale ? "Nữ" : "Nam";
                labelUserDateOfBirth.Text = string.IsNullOrEmpty(user.DateOfBirth.ToString(CultureInfo.CurrentCulture))
                    ? Resources.NullData
                    : user.DateOfBirth.ToString("dd/MM/yyyy");
                labelUserEmail.Text = string.IsNullOrEmpty(user.Email) ? Resources.NullData : user.Email;
                
                if (user.Room != null) {
                    labelResident.Text = "Người này đang ở tại căn hộ số " + user.Room.RoomNumber;
                    
                }   
                else {
                    labelResident.Text = "Người này hiện không sống ở căn hộ nào!";
                }
                
                
                LoadUserRentList(user);
            }
        }

        private void LoadUserRentList(User user) {
            ListViewUserRentList.Items.Clear();
            var contracts = _contractService.GetByUserIdAndNonExpiredWithRoom(user.Id);
            
            foreach (var contract in contracts) {
                var item = new ListViewItem(contract.User != null ? contract.Room.RoomNumber : Resources.NullData);
                item.SubItems.Add(string.IsNullOrEmpty(contract.EndDate.ToString("dd/MM/yyyy")) ? Resources.NullData : contract.EndDate.ToString("dd/MM/yyyy"));
                ListViewUserRentList.Items.Add(item);
            }
        }
        
        private void buttonAddTenant_Click(object sender, EventArgs e) {
            var userForm = new UserForm(null);
            userForm.ShowDialog();
            ShowUserDialogMessageResult(userForm.DialogResult, false);
        }

        private void buttonEditTenant_Click(object sender, EventArgs e) {
            var user = IsSelectedUserValid();

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

        private void buttonDeleteTenant_Click(object sender, EventArgs e) {
            var user = IsSelectedUserValid();
            if (user != null) {
                if (!IsUserSafeDelete(user.Id)) {
                    return;
                }

                var confirmationForm = new ConfirmationForm("Bạn có chắc chắn muốn xóa người thuê này không?");
                var result = confirmationForm.ShowDialog();
                if (result == DialogResult.Yes) {
                    var deleteResult = _userService.Delete(user.Id);
                    if (deleteResult) {
                        UserForeignInformationReload();
                        new ToastForm("Xóa thông tin người thuê thành công").Show();
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

        private bool IsUserSafeDelete(int userId) {
            if (_userService.IsExistContract(userId)) {
                new ToastForm("Dữ liệu đang tồn tại ở hợp đồng", true).Show();
                return false;
            }

            return true;
        }

        private void buttonEditTenantPassword_Click(object sender, EventArgs e) {
            var user = IsSelectedUserValid();

            if (user != null) {
                var changeUserPasswordForm = new ChangeUserPasswordForm(user);
                changeUserPasswordForm.Show();
            }
            else {
                new ToastForm("Vui lòng chọn người thuê cần sửa mật khẩu", true).Show();
            }
        }

        private void buttonChangeTenantAvatar_Click(object sender, EventArgs e) {
            var user = IsSelectedUserValid();
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
                        LoadTenantAvatar(user);
                        new ToastForm("Cập nhật thành công").Show();
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
                var index = ListViewUser.SelectedItems[0].Index;
                if (index < Users.Count) {
                    return Users[index];
                }
            }

            return null;
        }

        private void SelectUserAgain(User user) {
            var index = Users.IndexOf(user);

            if (ListViewUser.Items.Count > index) {
                ListViewUser.Items[index].Selected = true;
                ListViewUser.Select();
            }
        }

        private void UserForeignInformationReload() {
            LoadUserData();
            LoadRoomData();
        }
        
        private void buttonReloadUser_Click(object sender, EventArgs e)
        {
            LoadUserData();
            new ToastForm("Đã thực hiện tải dữ liệu người thuê").Show();
        }
        
        private void ButtonUserUnpaid_Click(object sender, EventArgs e)
        {
            LoadUserDataWithUnpaidBill();
            new ToastForm("Đã thực hiện tải dữ liệu người thuê nợ tiền").Show();
        }

        // Query System
        private void ButtonUserSearch_Click(object sender, EventArgs e)
        {
            bool? isFemale = QueryUtils.UserGender((string) comboBoxGender.SelectedItem);
            List<string> text = QueryUtils.ChangeUserSearchInput((string)comboBoxUserSearch.SelectedItem, textBoxUserSearch.Text);
            Users = _userService.GetByCustomizeQuery(isFemale, text);
            InsertUserIntoListView(Users);
        }
    }
}