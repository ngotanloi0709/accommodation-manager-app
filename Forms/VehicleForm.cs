using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System;
using System.Collections.Generic;

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
                setUpData(_vehicle);
                Text = "Chỉnh sửa thông tin phương tiện";
            }
        }

        private void SetUpComboBoxes()
        {
            comboBoxRoom.Items.Add("None");
            foreach (var room in _rooms)
            {
                comboBoxRoom.Items.Add(room.RoomNumber);
            }
            comboBoxRoom.SelectedIndex = 0;
        }
        private void setUpData(Vehicle vehicle)
        {
            textBoxType.Text = vehicle.type;
            textBoxName.Text = vehicle.name;
            textBoxNumber.Text = vehicle.number;
            comboBoxRoom.SelectedItem = vehicle.Room?.RoomNumber ?? "None" ;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string VehicleName = textBoxName.Text;
            string VehicleType = textBoxType.Text;
            string VehicleNumber = textBoxNumber.Text;
            int? roomId = comboBoxRoom.SelectedItem.ToString().Equals("None") ? null : _roomService.GetIdByRoomNumber(comboBoxRoom.SelectedItem.ToString());
            if(VehicleName.Equals("") || VehicleType.Equals("") || VehicleNumber.Equals(""))
            {
                new ToastForm("Vui lòng nhập đầy đủ thông tin").Show();
                return;
            }
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
