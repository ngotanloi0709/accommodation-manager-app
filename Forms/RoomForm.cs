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
        private Room _room;
        private List<Building> _buildings;

        public RoomForm(Room room)
        {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _buildingService = ServiceLocator.ServiceProvider.GetService(typeof(BuildingService)) as BuildingService;

            _room = room;
            if (_buildingService != null) _buildings = _buildingService.GetAll();

            InitializeComponent();
            SetUpComboBoxes();

            if (_room != null)
            {
                SetUpData(_room);
                Text = "Chỉnh sửa thông tin căn hộ";
            }
        }

        private void SetUpComboBoxes()
        {
            comboBoxRoomBuilding.Items.Add("None");


            foreach (var building in _buildings)
            {
                comboBoxRoomBuilding.Items.Add(building.Name);
            }

            comboBoxRoomStatus.Items.Add(RoomStatus.Normal.ToVietnamese());
            comboBoxRoomStatus.Items.Add(RoomStatus.UnderMaintenance.ToVietnamese());

            comboBoxRoomBuilding.SelectedIndex = 0;
            comboBoxRoomStatus.SelectedIndex = 0;
        }

        private void SetUpData(Room room)
        {
            textBoxRoomName.Text = room.RoomNumber;
            comboBoxRoomBuilding.SelectedItem = room.Building?.Name ?? "None";
            comboBoxRoomStatus.SelectedItem = room.Status.ToVietnamese();
        }

        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            if (!IsAllTextBoxFilled() || !IsRoomNumberSafe())
            {
                return;
            }
            
            string roomNumber = textBoxRoomName.Text;
            int? buildingId = comboBoxRoomBuilding.SelectedItem.ToString().Equals("None") ? null : _buildingService.GetIdByName(comboBoxRoomBuilding.SelectedItem.ToString());
            RoomStatus status = comboBoxRoomStatus.SelectedItem.ToString().ToRoomStatus();

            if (_room == null)
            {
                _roomService.Add(new Room(roomNumber, buildingId, status));
            }
            else
            {
                _room.RoomNumber = roomNumber;
                _room.BuildingId = buildingId;
                _room.Status = status;
                
                _roomService.Update(_room.Id, _room);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        
        private bool IsRoomNumberSafe()
        {
            if ((_room == null || _room.RoomNumber != textBoxRoomName.Text) &&
                _roomService.IsRoomNumberExists(textBoxRoomName.Text))
            {
                new ToastForm("Số nhà đã tồn tại. Vui lòng nhập số nhà khác.", true).Show();
                return false;
            }

            return true;
        }
        
        private bool IsAllTextBoxFilled()
        {
            bool result = string.IsNullOrEmpty(textBoxRoomName.Text);
            
            if (result) {
                new ToastForm("Vui lòng điền đầy đủ thông tin.", true).Show();
            }
            
            return !result;
        }

        private void RoomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}