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
                    ListViewItem item = new ListViewItem(string.IsNullOrEmpty(room.RoomNumber) ? Resources.NullData : room.RoomNumber);
                    item.SubItems.Add(room.Building == null || string.IsNullOrEmpty(room.Building.Name) ? Resources.NullData : room.Building.Name);
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
                var confirmationForm = new ConfirmationForm("Bạn có chắc chắn muốn xóa người dùng này không?");
                var result = confirmationForm.ShowDialog();
                if (result == DialogResult.Yes) {
                    var deleteResult = _userService.Delete(user.Id);
                    if (deleteResult) {
                        UserForeignInformationReload();
                        new ToastForm("Xóa thông tin người dùng thành công", false).Show();
                    }
                    else {
                        new ToastForm("Xóa thông tin người dùng thất bại", true).Show();
                    }
                }
            }
            else {
                new ToastForm("Vui lòng chọn thông tin cần xóa", true).Show();
            }
        }
        
        private void buttonEditTenantPassword_Click(object sender, System.EventArgs e)
        {

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