using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms {
    public partial class ViewUserRoomInformation : BaseForm {
        private readonly RoomService _roomService;
        private readonly ContractService _contractService;
        private readonly User _user;
        private List<Contract> Contracts { get; set; }

        public ViewUserRoomInformation(User user) {
            InitializeComponent();
            ListViewUserRoom.GridLines = true;
            
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _contractService = ServiceLocator.ServiceProvider.GetService(typeof(ContractService)) as ContractService;
            _user = user;
            
            LoadUserRoomInfor();
        }

        private void LoadUserRoomInfor() {
            var contracts = _contractService.GetByUserIdAndNonExpiredWithRoom(_user.Id);
            Contracts = contracts;
            
            if (contracts.Count == 0) return;
            
            foreach (var contract in contracts) {
                var item = new ListViewItem(contract.Room.Id.ToString());
                var room = _roomService.GetAllWithBuildingAndUserAndContractWithUser().Find(r => r.Id == contract.Room.Id);
                
                item.SubItems.Add(room.Building != null ? room.Building.Name : Resources.NullData);
                item.SubItems.Add(contract.Room.Status.ToVietnamese());
                item.SubItems.Add(contract.Room.RoomNumber);
                ListViewUserRoom.Items.Add(item);
            }
        }

        private Contract IsSelectedRoomValid() {
            if (ListViewUserRoom.SelectedItems.Count <= 0) return null;
            
            var index = ListViewUserRoom.SelectedItems[0].Index;
            
            if (index >= Contracts.Count) return null;
            
            var contract = Contracts[index];
            
            return contract;
        }

        private void ListViewUserRoom_SelectedIndexChanged(object sender, EventArgs e) {
            var contract = IsSelectedRoomValid();
            
            if (contract == null) return;
            
            var room = _roomService.GetAllWithBuildingAndUserAndContractWithUser().Find(r => r.Id == contract.Room.Id);
            
            if (room == null) return;
            
            labelRoomNumber.Text = room.RoomNumber;
            labelRoomBuilding.Text = room.Building != null ? room.Building.Name : Resources.NullData;
            labelRoomStatus.Text = room.Status.ToVietnamese();
            labelRoomTenant.Text = _user.Name;
        }
    }
}