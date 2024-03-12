using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm {
        private void LoadRoomData() {
            Rooms = _roomService.GetAllWithBuildingAndUser();

            foreach (var room in Rooms) {
                ListViewItem item = new ListViewItem(room.RoomNumber);
                if (room.Building != null) {
                    item.SubItems.Add(room.Building.Name);
                }
                else {
                    item.SubItems.Add(Resources.NullData);
                }

                if (room.User != null) {
                    item.SubItems.Add(room.User.Name);
                }
                else {
                    item.SubItems.Add(Resources.NullData);
                }

                item.SubItems.Add(room.Status.ToVietnamese());
                ListViewRoom.Items.Add(item);
            }
        }

        private void ListViewRoom_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (ListViewRoom.SelectedItems.Count > 0) {
                int index = ListViewRoom.SelectedItems[0].Index;
                if (index < Rooms.Count) {
                    Room room = Rooms[index];

                    string id = room.Id.ToString();
                    string number = room.RoomNumber;
                    string status = room.Status.ToVietnamese();

                    labelRoomId.Text = id.Equals("") ? Resources.NullData : id;
                    labelRoomNumber.Text = number == null || number.Equals("") ? Resources.NullData : number;
                    
                    if (room.Building != null) {
                        string building = room.Building.Name;
                        labelRoomBuilding.Text = building == null || building.Equals("") ? Resources.NullData : building;
                    }
                    else {
                        labelRoomBuilding.Text = Resources.NullData;
                    }

                    if (room.User != null) {
                        string tenant = room.User.Name;
                        labelRoomTenant.Text = tenant == null || tenant.Equals("") ? Resources.NullData : tenant;
                    }
                    else {
                        labelRoomTenant.Text = Resources.NullData;
                    }

                    labelRoomStatus.Text = status.Equals("") ? Resources.NullData : status;
                }
            }
        }
    }
}