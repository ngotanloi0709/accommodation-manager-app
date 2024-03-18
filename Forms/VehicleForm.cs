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
            string VehicleName = textBoxName.Text;
            string VehicleType = textBoxType.Text;
            string VehicleNumber = textBoxNumber.Text;
            int? roomId = comboBoxRoom.SelectedItem.ToString().Equals("None") ? null : _roomService.GetIdByRoomNumber(comboBoxRoom.SelectedItem.ToString());
            if (_vehicle == null && _vehicleService.IsVehicleNumberExists(VehicleNumber))
            {
                new ToastForm("Tên phương tiện đã tồn tại").Show();
                return;
            }
            if(_vehicle == null)
            {
                _vehicleService.Add(new Vehicle
                {
                    name = VehicleName,
                    type = VehicleType,
                    number = VehicleNumber,
                    RoomId = roomId
                });
            }
            else { 
                
                _vehicle.name = VehicleName;
                _vehicle.type = VehicleType;
                _vehicle.number = VehicleNumber;
                _vehicle.RoomId = roomId;
                _vehicleService.Update(_vehicle.Id, _vehicle);
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

    }
}
