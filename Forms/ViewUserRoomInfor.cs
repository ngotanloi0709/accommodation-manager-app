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
    public partial class ViewUserRoomInfor : BaseForm

    {
        private readonly RoomService _roomService;
        private readonly ContractService _contractService;
        private User _user;
        private List<Room> Rooms { get; set; }
        private List<Contract> Contracts { get; set; }
        private int count;
        public ViewUserRoomInfor(User user)
        {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _contractService = ServiceLocator.ServiceProvider.GetService(typeof(ContractService)) as ContractService;
            _user = user;
            InitializeComponent();
            LoadUserRoomInfor();
        }
        private void LoadUserRoomInfor()
        {
            List<Contract> _contracts = _contractService.GetByUserIdAndNonExpiredWithRoom(_user.Id);
            Contracts = _contracts;
            Console.WriteLine(Contracts.Count);
            if (_contracts.Count != 0)
            {
                foreach (var contract in _contracts)
                {
                    ListViewItem item = new ListViewItem(contract.Room.Id.ToString());
                    Room _room = _roomService.GetAllWithBuildingAndUserAndContractWithUser().Find(r => r.Id == contract.Room.Id);
                    item.SubItems.Add(_room.Building != null ? _room.Building.Name : Resources.NullData);
                    item.SubItems.Add(contract.Room.Status.ToVietnamese());
                    item.SubItems.Add(contract.Room.RoomNumber);
                    ListViewUserRoom.Items.Add(item);
                }
            }
        }
        private Contract IsSelectedRoomValid()
        {
            if (ListViewUserRoom.SelectedItems.Count > 0)
            {
                var index = ListViewUserRoom.SelectedItems[0].Index;
                Console.WriteLine(index);
                if (index < Contracts.Count)
                {
                    var contract = Contracts[index];
                    return contract;
                }
            }

            return null;
        }

        private void ListViewUserRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contract = IsSelectedRoomValid();
            if (contract != null)
            {
                Room room = _roomService.GetAllWithBuildingAndUserAndContractWithUser().Find(r => r.Id == contract.Room.Id);
                if (room != null)
                {
                    labelRoomNumber.Text = room.RoomNumber;
                    labelRoomBuilding.Text = room.Building != null ? room.Building.Name : Resources.NullData;
                    labelRoomStatus.Text = room.Status.ToVietnamese();
                    labelRoomTenant.Text = _user.Name;
                }
            }
        }
    }
}
