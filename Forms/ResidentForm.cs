using System.Collections.Generic;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;

namespace AccommodationManagerApp.Forms
{
    public partial class ResidentForm : BaseForm {
        private readonly UserService _userService;
        private readonly RoomService _roomService;
        private User _user;
        private Room _room;
        
        public ResidentForm(User user, Room room)
        {
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _user = user;
            _room = room;
            
            InitializeComponent();

            if (_user != null) {
                SetUpDataForUser();
            } else {
                SetUpDataForRoom();
            }
        }
        
        // if the form is opened from RoomManagementForm
        private void SetUpDataForRoom() {
            comboBoxRoomNumber.Items.Add(_room.RoomNumber);
            comboBoxRoomNumber.SelectedIndex = 0;
            comboBoxRoomNumber.Enabled = false;
            
            var users = _userService.GetAllWithRoleTenant();
            
            comboBoxName.Items.Add("None");
            foreach (var user in users) {
                comboBoxName.Items.Add(user.Name);
            }
            
            comboBoxName.SelectedIndex = 0;
            
            comboBoxEmail.Items.Add("None");
            comboBoxEmail.SelectedIndex = 0;
        }

        // if the form is opened from ResidentManagementForm
        private void SetUpDataForUser() {
            comboBoxName.Items.Add(_user.Name);
            comboBoxName.SelectedIndex = 0;
            comboBoxName.Enabled = false;
            
            comboBoxEmail.Items.Add(_user.Email);
            comboBoxEmail.SelectedIndex = 0;
            comboBoxEmail.Enabled = false;
            
            var rooms = _roomService.GetAll();
            comboBoxRoomNumber.Items.Add("None");
            
            foreach (var room in rooms) {
                comboBoxRoomNumber.Items.Add(room.RoomNumber);
            }
        }

        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            if (IsAllDataFilled()) {
                User user;
                if (_user == null) {
                    user = _userService.GetByNameAndEmail(comboBoxName.Text, comboBoxEmail.Text);
                }
                else {
                    user = _user;
                }
                
                var updateId = _roomService.GetIdByRoomNumber(comboBoxRoomNumber.Text);
                
                if (user.RoomId != null) {
                    var room = _roomService.GetById((int) user.RoomId);
                    
                    if (room != null && room.Id != updateId && !IsProceedUpdate(room)) {
                        return;
                    }
                }
                
                user.RoomId = updateId;
                _userService.Update(user.Id, user);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool IsProceedUpdate(Room room) {
            var confirmationForm = new ConfirmationForm("Người thuê này đã ở phòng " + room.RoomNumber + ". Bạn có chắc chắn muốn chuyển phòng không?");
            confirmationForm.ShowDialog();

            return confirmationForm.DialogResult == DialogResult.Yes;
        }

        private bool IsAllDataFilled() {
            if (comboBoxName.Text.Equals("None")) {
                new ToastForm("Vui lòng chọn tên người thuê", true).Show();
                return false;
            }
            
            if (comboBoxEmail.Text.Equals("None")) {
                new ToastForm("Vui lòng chọn email người thuê", true).Show();
                return false;
            }
            
            if (comboBoxRoomNumber.Text.Equals("None")) {
                new ToastForm("Vui lòng chọn số phòng", true).Show();
                return false;
            }
            
            return true;
        }

        private void comboBoxName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBoxName.SelectedIndex == 0) {
                return;
            }

            var users = _userService.GetAllEmailByName(comboBoxName.Text);

            comboBoxEmail.Items.Clear();
            comboBoxEmail.Items.Add("None");
            foreach (var user in users) {
                comboBoxEmail.Items.Add(user);
            }

            if (comboBoxEmail.Items.Count == 1) {
                comboBoxEmail.SelectedIndex = 0;
            }
            else {
                comboBoxEmail.SelectedIndex = 1;
            }
        }

        private void ResidentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK) {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}