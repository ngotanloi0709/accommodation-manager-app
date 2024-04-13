using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;
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
    public partial class ViewUserVehicleInfor : BaseForm
    {
        private readonly RoomService _roomService;
        private readonly ContractService _contractService;
        private readonly VehicleService _vehicleService;
        private readonly User _user;
        private List<Vehicle> Vehicle { get; set; }
        public ViewUserVehicleInfor(User user)
        {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _contractService = ServiceLocator.ServiceProvider.GetService(typeof(ContractService)) as ContractService;
            _vehicleService = ServiceLocator.ServiceProvider.GetService(typeof(VehicleService)) as VehicleService;
            _user = user;
            InitializeComponent();
            LoadUserVehicleData();
        }

        private void LoadUserVehicleData()
        {
            ListViewUserVehicle.Items.Clear();
            List<Contract> contracts = _contractService.GetByUserIdAndNonExpiredWithRoom(_user.Id);
            Contract result = contracts.Where(c => c.StartDate <= DateTime.Now && c.EndDate >= DateTime.Now).FirstOrDefault();
            if(result == null)
            {
                return;
            }
            Vehicle = _vehicleService.GetAllByRoomId(result.Room.Id);
            if(Vehicle.Count != 0)
            {
                foreach(var vehicle in Vehicle)
                {
                    ListViewItem item = new ListViewItem(vehicle.Name);
                    item.SubItems.Add(vehicle.Number);
                    item.SubItems.Add(vehicle.Category.ToVietnamese());
                    ListViewUserVehicle.Items.Add(item);
                }
            }

        }


        private Vehicle IsSelectedVehicleValid()
        {
            if (ListViewUserVehicle.SelectedItems.Count > 0)
            {
                var index = ListViewUserVehicle.SelectedItems[0].Index;
                if (index >= 0 && index < Vehicle.Count)
                {
                    return Vehicle[index];
                }
            }

            return null;
        }

        private void ListViewUserVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehicle vehicle = IsSelectedVehicleValid();
            if (vehicle != null)
            {
                var roomNumber = vehicle.Room != null ? vehicle.Room.RoomNumber : Resources.NullData;
                labelVehicleName.Text = string.IsNullOrEmpty(vehicle.Name) ? Resources.NullData : vehicle.Name;
                labelVehicleNumber.Text = string.IsNullOrEmpty(vehicle.Number) ? Resources.NullData : vehicle.Number;
                labelVehicleType.Text = string.IsNullOrEmpty(vehicle.Category.ToVietnamese()) ? Resources.NullData : vehicle.Category.ToVietnamese();
                labelVehicleRoom.Text = string.IsNullOrEmpty(roomNumber) ? Resources.NullData : roomNumber;
                lableVehiclePrice.Text = string.IsNullOrEmpty(vehicle.Price.ToString()) ? Resources.NullData : FormatText.IntegerToVnd(vehicle.Price);
            }
        }
    }
}
