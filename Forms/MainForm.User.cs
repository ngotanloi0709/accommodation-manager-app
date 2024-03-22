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
                labelUserIdentityNumber.Text = string.IsNullOrEmpty(user.IdentityNumber) ? Resources.NullData : user.IdentityNumber;
                labelUserSex.Text = user.IsFemale ? "Nữ" : "Nam";
                labelUserDateOfBirth.Text = string.IsNullOrEmpty(user.DateOfBirth.ToString()) ? Resources.NullData : user.DateOfBirth.ToString("dd/MM/yyyy");
                labelUserEmail.Text = string.IsNullOrEmpty(user.Email) ? Resources.NullData : user.Email;
                
                ListViewUserRentList.Items.Clear();
                foreach (var room in user.Rooms) {
                    ListViewItem item = new ListViewItem(string.IsNullOrEmpty(room.RoomNumber) ? Resources.NullData : room.RoomNumber);
                    item.SubItems.Add(string.IsNullOrEmpty(room.Building.Name) ? Resources.NullData : room.Building.Name);
                    ListViewUserRentList.Items.Add(item);
                }
            }
        }

        private User IsSelectedUserValid() {
            if (ListViewUser.SelectedItems.Count > 0) {
                int index = ListViewUser.SelectedItems[0].Index;
                if (index < Buildings.Count) {
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