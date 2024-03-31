using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm {
        private void LoadRoomData() {
            ListViewRoom.Items.Clear();
            Rooms = _roomService.GetAllWithBuildingAndUserAndContractWithUser();

            foreach (var room in Rooms) {
                ListViewItem item = new ListViewItem(room.RoomNumber);
                item.SubItems.Add(room.Building != null ? room.Building.Name : Resources.NullData);
                item.SubItems.Add(_roomService.GetCurrentTenantName(room));
                item.SubItems.Add(room.Status.ToVietnamese());
                ListViewRoom.Items.Add(item);
            }
        }


        private void ListViewRoom_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            Room room = IsSelectedRoomValid();

            if (room != null) {
                string number = room.RoomNumber;
                Building building = room.Building;
                string status = room.Status.ToVietnamese();

                labelRoomNumber.Text = number == null || number.Equals("") ? Resources.NullData : number;
                labelRoomTenant.Text = _roomService.GetCurrentTenantName(room);
                labelRoomStatus.Text = status.Equals("") ? Resources.NullData : status;

                if (building != null) {
                    string buildingName = room.Building.Name;
                    labelRoomBuilding.Text = buildingName == null || buildingName.Equals("")
                        ? Resources.NullData
                        : buildingName;
                }
                else {
                    labelRoomBuilding.Text = Resources.NullData;
                }

                LoadRoomUserList(room);
            }
        }

        private void LoadRoomUserList(Room room) {
            ListViewRoomUserList.Items.Clear();
            List<User> users = room.Users;

            foreach (var user in users) {
                ListViewItem item = new ListViewItem(user.Name);
                item.SubItems.Add(user.Email);
                ListViewRoomUserList.Items.Add(item);
            }

            try {
                labelCurrentStayNumber.Text = users.Count + " người ở";
            }
            catch (Exception e) {
                labelCurrentStayNumber.Text = "0 người ở";
                Console.WriteLine(e);
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
                if (!IsRoomSafeDelete(room.Id)) {
                    return;
                }

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

        private bool IsRoomSafeDelete(int roomId) {
            if (_roomService.IsExistContract(roomId)) {
                new ToastForm("Dữ liệu đang tồn tại ở hợp đồng", true).Show();
                return false;
            }

            return true;
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

        private void buttonAddResidentToRoom_Click(object sender, System.EventArgs e) {
            Room room = IsSelectedRoomValid();
            if (room != null) {
                var residentForm = new ResidentForm(null, room);
                residentForm.ShowDialog();

                if (residentForm.DialogResult == DialogResult.Cancel) {
                    return;
                }

                if (residentForm.DialogResult == DialogResult.OK) {
                    LoadRoomData();
                    SelectRoomAgain(room);
                    new ToastForm("Thêm cư dân vào căn hộ thành công", false).Show();
                }
                else {
                    new ToastForm("Thêm cư dân vào căn hộ thất bại", true).Show();
                }
            }
            else {
                new ToastForm("Vui lòng chọn căn hộ", true).Show();
            }
        }

        private void buttonRemoveResidentFromRoom_Click(object sender, System.EventArgs e) {
            Room room = IsSelectedRoomValid();

            if (ListViewRoomUserList.SelectedItems.Count > 0) {
                string name = ListViewRoomUserList.SelectedItems[0].Text;
                string email = ListViewRoomUserList.SelectedItems[0].SubItems[1].Text;
                User user = _userService.GetByNameAndEmail(name, email);

                if (user != null) {
                    var confirmationForm = new ConfirmationForm("Bạn có chắc chắn muốn xóa nhân khẩu này không?");
                    var result = confirmationForm.ShowDialog();
                    if (result == DialogResult.Yes) {
                        user.RoomId = null;
                        _userService.Update(user.Id, user);
                        LoadRoomData();
                        SelectRoomAgain(room);
                        new ToastForm("Xóa nhân khẩu khỏi căn hộ thành công").Show();
                    }
                }
                else {
                    new ToastForm("Không tìm thấy nhân khẩu", true).Show();
                }
            }
            else {
                new ToastForm("Vui lòng chọn nhân khẩu", true).Show();
            }
        }
    }
}