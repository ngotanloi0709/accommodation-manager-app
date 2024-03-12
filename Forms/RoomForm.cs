using System.Collections.Generic;
using AccommodationManagerApp.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TenantManagementSystem.Forms
{
    public partial class RoomForm : BaseForm
    {
        private readonly RoomService _roomService;
        private Room _room;
        private List<Building> _buildings;
        private List<User> _users;
        
        public RoomForm(Room room, List<Building> buildings, List<User> users)
        {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _room = room;
            _buildings = buildings;
            _users = users;
            InitializeComponent();
            SetUpComboBoxes();
            if (_room != null) {
                SetUpData(_room);
            }
        }
        
        private void SetUpComboBoxes() {
            comboBoxRoomBuilding.Items.Add("None");
            comboBoxRoomTenant.Items.Add("None");
            foreach (var building in _buildings) {
                comboBoxRoomBuilding.Items.Add(building.Name);
            }
            foreach (var user in _users) {
                comboBoxRoomTenant.Items.Add(user.Name);
            }
        }
        
        private void SetUpData(Room room) {
            textBoxRoomName.Text = room.RoomNumber;
        }

        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            
        }

        private void ButtonClose_Click(object sender, System.EventArgs e) {
            CloseForm();
        }
        
        private void CloseForm() {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}