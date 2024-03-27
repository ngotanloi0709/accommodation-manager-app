using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm {
        private void LoadRoomData() {
            ListViewRoom.Items.Clear();
            Rooms = _roomService.GetAllWithBuildingAndContract();

            foreach (var room in Rooms) {
                ListViewItem item = new ListViewItem(room.RoomNumber);
                item.SubItems.Add(room.Building != null ? room.Building.Name : Resources.NullData);
                item.SubItems.Add(Resources.NullData);
                item.SubItems.Add(room.Status.ToVietnamese());
                ListViewRoom.Items.Add(item);
            }
        }

        private void ListViewRoom_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            Room room = IsSelectedRoomValid();
            if (room != null) {
                string id = room.Id.ToString();
                string number = room.RoomNumber;
                Building building = room.Building;
                string status = room.Status.ToVietnamese();

                labelRoomId.Text = id.Equals("") ? Resources.NullData : id;
                labelRoomNumber.Text = number == null || number.Equals("") ? Resources.NullData : number;

                if (building != null) {
                    string buildingName = room.Building.Name;
                    labelRoomBuilding.Text = buildingName == null || buildingName.Equals("")
                        ? Resources.NullData
                        : buildingName;
                }
                else {
                    labelRoomBuilding.Text = Resources.NullData;
                }

                labelRoomTenant.Text = Resources.NullData;

                labelRoomStatus.Text = status.Equals("") ? Resources.NullData : status;
            }
        }


        private void buttonAddRoom_Click(object sender, System.EventArgs e) {
            var roomForm = new RoomForm(null);
            roomForm.ShowDialog();
            ShowRoomDialogMessageResult(roomForm.DialogResult, false);
        }


        private void buttonEditRoom_Click(object sender, System.EventArgs e) {
            Room room = IsSelectedRoomValid();

            if (room != null) {
                var roomForm = new RoomForm(room);
                roomForm.ShowDialog();
                ShowRoomDialogMessageResult(roomForm.DialogResult, true);
                SelectRoomAgain(room);
            }
            else {
                new ToastForm("Vui lòng chọn căn hộ", true).Show();
            }
        }

        private void ShowRoomDialogMessageResult(DialogResult dialogResult, bool isEdit) {
            string message;
            if (dialogResult == DialogResult.Cancel) {
                return;
            }

            if (dialogResult == DialogResult.OK) {
                if (isEdit) {
                    RoomForeignInformationReload();
                }
                else {
                    LoadRoomData();
                }

                message = isEdit
                    ? "Sửa thông tin căn hộ thành công"
                    : "Thêm thông tin căn hộ mới thành công";
            }
            else {
                message = isEdit ? "Sửa thông tin căn hộ thất bại" : "Thêm thông tin căn hộ mới thất bại";
            }

            new ToastForm(message, dialogResult != DialogResult.OK).Show();
        }

        private void buttonDeleteRoom_Click(object sender, System.EventArgs e) {
            Room room = IsSelectedRoomValid();
            if (room != null) {
                var confirmationForm = new ConfirmationForm("Bạn có chắc chắn muốn xóa căn hộ này không?");
                var result = confirmationForm.ShowDialog();
                if (result == DialogResult.Yes) {
                    var deleteResult = _roomService.Delete(room.Id);
                    if (deleteResult) {
                        RoomForeignInformationReload();
                        new ToastForm("Xóa thông tin căn hộ thành công", false).Show();
                    }
                    else {
                        new ToastForm("Xóa thông tin căn hộ thất bại", true).Show();
                    }
                }
            }
            else {
                new ToastForm("Vui lòng chọn thông tin cần xóa", true).Show();
            }
        }

        private Room IsSelectedRoomValid() {
            if (ListViewRoom.SelectedItems.Count > 0) {
                int index = ListViewRoom.SelectedItems[0].Index;
                if (index < Rooms.Count) {
                    Room room = Rooms[index];
                    return room;
                }
            }

            return null;
        }

        private void SelectRoomAgain(Room room) {
            var index = Rooms.IndexOf(room);

            if (ListViewRoom.Items.Count > index) {
                ListViewRoom.Items[index].Selected = true;
                ListViewRoom.Select();
            }
        }

        private void RoomForeignInformationReload() {
            LoadRoomData();
            LoadVehicleData();
        }

        private void buttonReloadRoom_Click(object sender, System.EventArgs e) {
            LoadRoomData();
            new ToastForm("Đã thực hiện tải lại dữ liệu chung cư", false).Show();
        }
    }
}