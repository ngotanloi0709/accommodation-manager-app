using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class RoomForm : BaseForm
    {
        private readonly RoomService _roomService;
        private readonly BuildingService _buildingService;
        private readonly UserService _userService;
        private Room _room;
        private List<Building> _buildings;
        private List<User> _users;

        public RoomForm(Room room)
        {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _buildingService = ServiceLocator.ServiceProvider.GetService(typeof(BuildingService)) as BuildingService;
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;

            _room = room;
            if (_buildingService != null) _buildings = _buildingService.GetAll();
            if (_userService != null) _users = _userService.GetAll();

            InitializeComponent();
            SetUpComboBoxes();

            if (_room != null)
            {
                SetUpData(_room);
            }
        }

        private void SetUpComboBoxes()
        {
            comboBoxRoomBuilding.Items.Add("None");
            comboBoxRoomTenant.Items.Add("None");

            foreach (var building in _buildings)
            {
                comboBoxRoomBuilding.Items.Add(building.Name);
            }

            foreach (var user in _users)
            {
                comboBoxRoomTenant.Items.Add(user.Name);
            }

            comboBoxRoomStatus.Items.Add(RoomStatus.Empty.ToVietnamese());
            comboBoxRoomStatus.Items.Add(RoomStatus.Rented.ToVietnamese());
            comboBoxRoomStatus.Items.Add(RoomStatus.UnderMaintenance.ToVietnamese());

            comboBoxRoomBuilding.SelectedIndex = 0;
            comboBoxRoomTenant.SelectedIndex = 0;
            comboBoxRoomStatus.SelectedIndex = 0;
        }

        private void SetUpData(Room room)
        {
            textBoxRoomName.Text = room.RoomNumber;
            comboBoxRoomBuilding.SelectedItem = room.Building?.Name ?? "None";
            comboBoxRoomTenant.SelectedItem = room.User?.Name ?? "None";
            comboBoxRoomStatus.SelectedItem = room.Status.ToVietnamese();
        }

        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            string roomNumber = textBoxRoomName.Text;
            int? buildingId = comboBoxRoomBuilding.SelectedItem.ToString().Equals("None") ? null : _buildingService.GetIdByName(comboBoxRoomBuilding.SelectedItem.ToString());
            int? userId = comboBoxRoomTenant.SelectedItem.ToString().Equals("None") ? null : _userService.GetIdByName(comboBoxRoomTenant.SelectedItem.ToString());
            RoomStatus status = comboBoxRoomStatus.SelectedItem.ToString().ToRoomStatus();

            if (_room == null && _roomService.IsRoomNumberExists(roomNumber))
            {
                new ToastForm("Số nhà đã tồn tại. Vui lòng nhập số nhà khác.", true).Show();
                return;
            }

            if (_room == null)
            {
                _roomService.Add(new Room(roomNumber, buildingId, userId, status));
            }
            else
            {
                _room.RoomNumber = roomNumber;
                _room.BuildingId = buildingId;
                _room.UserId = userId;
                _room.Status = status;
                _roomService.Update(_room.Id, _room);
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void RoomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}