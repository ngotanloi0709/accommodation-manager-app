using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms {
    public partial class ViewUserVehicleInformation : BaseForm {
        private readonly ContractService _contractService;
        private readonly VehicleService _vehicleService;
        private readonly User _user;
        private List<Vehicle> Vehicle { get; set; }

        public ViewUserVehicleInformation(User user) {
            InitializeComponent();
            ListViewUserVehicle.GridLines = true;
            
            _contractService = ServiceLocator.ServiceProvider.GetService(typeof(ContractService)) as ContractService;
            _vehicleService = ServiceLocator.ServiceProvider.GetService(typeof(VehicleService)) as VehicleService;
            _user = user;
            
            LoadUserVehicleData();
        }

        private void LoadUserVehicleData() {
            ListViewUserVehicle.Items.Clear();
            var contracts = _contractService.GetByUserIdAndNonExpiredWithRoom(_user.Id);
            var result = contracts.Where(c => c.StartDate <= DateTime.Now && c.EndDate >= DateTime.Now).ToList();
            
            if (result.Count == 0) {
                return;
            }

            foreach (var contract in result) {
                Vehicle = _vehicleService.GetAllByRoomId(contract.Room.Id);
                if (Vehicle.Count == 0) return;
            
                foreach (var vehicle in Vehicle) {
                    var item = new ListViewItem(vehicle.Name);
                    item.SubItems.Add(vehicle.Number);
                    item.SubItems.Add(vehicle.Category.ToVietnamese());
                    ListViewUserVehicle.Items.Add(item);
                }
            }
        }

        private Vehicle IsSelectedVehicleValid() {
            if (ListViewUserVehicle.SelectedItems.Count <= 0) return null;
            
            var index = ListViewUserVehicle.SelectedItems[0].Index;
            
            if (index >= 0 && index < Vehicle.Count) {
                return Vehicle[index];
            }

            return null;
        }

        private void ListViewUserVehicle_SelectedIndexChanged(object sender, EventArgs e) {
            var vehicle = IsSelectedVehicleValid();

            if (vehicle == null) return;
            
            var roomNumber = vehicle.Room != null ? vehicle.Room.RoomNumber : Resources.NullData;
            labelVehicleName.Text = string.IsNullOrEmpty(vehicle.Name) ? Resources.NullData : vehicle.Name;
            labelVehicleNumber.Text = string.IsNullOrEmpty(vehicle.Number) ? Resources.NullData : vehicle.Number;
            labelVehicleType.Text = string.IsNullOrEmpty(vehicle.Category.ToVietnamese())
                ? Resources.NullData
                : vehicle.Category.ToVietnamese();
            labelVehicleRoom.Text = string.IsNullOrEmpty(roomNumber) ? Resources.NullData : roomNumber;
            lableVehiclePrice.Text = string.IsNullOrEmpty(vehicle.Price.ToString())
                ? Resources.NullData
                : FormatText.IntegerToVnd(vehicle.Price);
        }
    }
}