using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class VehicleForm : BaseForm
    {
        private readonly VehicleService _vehicleService;
        private readonly RoomService _roomService;
        private Vehicle _vehicle; 
        private List<Room> _rooms;
        

        public VehicleForm(Vehicle vehicle)
        {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _vehicleService = ServiceLocator.ServiceProvider.GetService(typeof(VehicleService)) as VehicleService;
            _vehicle = vehicle;
            _rooms = _roomService.GetAll();
            
            InitializeComponent();
            SetUpComboBoxes();
            if(_vehicle != null)
            {
                setUpData();
            }
        }

        private void SetUpComboBoxes()
        {
            comboBoxRoom.Items.Add("None");
            foreach (var room in _rooms)
            {
                comboBoxRoom.Items.Add(room.RoomNumber);
            }
        }
        private void setUpData()
        {
            textBoxType.Text = _vehicle.type;
            textBoxName.Text = _vehicle.name;
            textBoxNumber.Text = _vehicle.number;
            comboBoxRoom.Text = _vehicle.Room != null ? _vehicle.Room.RoomNumber : "None";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_vehicle == null)
            {
                _vehicle = new Vehicle();
            }
            _vehicle.type = textBoxType.Text;
            _vehicle.name = textBoxName.Text;
            _vehicle.number = textBoxNumber.Text;
            _vehicle.Room = comboBoxRoom.Text.Equals("None") ? null : _rooms.Find(r => r.RoomNumber.Equals(comboBoxRoom.Text));
            _vehicleService.Save(_vehicle);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
