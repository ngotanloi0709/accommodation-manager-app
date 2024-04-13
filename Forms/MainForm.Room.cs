using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm {
        private void LoadRoomData() {
            Rooms = _roomService.GetAllWithBuildingAndUserAndContractWithUser();
            InsertRoomIntoListView(Rooms);
        }

        private void InsertRoomIntoListView(List<Room> rooms)
        {
            ListViewRoom.Items.Clear();
            foreach (var room in rooms)
            {
                var item = new ListViewItem(room.RoomNumber);
                item.SubItems.Add(room.Building != null ? room.Building.Name : Resources.NullData);
                item.SubItems.Add(_roomService.GetCurrentTenantName(room));
                item.SubItems.Add(room.Status.ToVietnamese());
                ListViewRoom.Items.Add(item);
            }
        }

        private void ListViewRoom_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            var room = IsSelectedRoomValid();

            if (room != null) {
                var number = room.RoomNumber;
                var building = room.Building;
                var status = room.Status.ToVietnamese();

                labelRoomNumber.Text = number == null || number.Equals("") ? Resources.NullData : number;
                labelRoomTenant.Text = _roomService.GetCurrentTenantName(room);
                labelRoomStatus.Text = status.Equals("") ? Resources.NullData : status;

                if (building != null) {
                    var buildingName = room.Building.Name;
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
            var users = room.Users;

            foreach (var user in users) {
                var item = new ListViewItem(user.Name);
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

        private void buttonAddRoom_Click(object sender, EventArgs e) {
            var roomForm = new RoomForm(null);
            roomForm.ShowDialog();
            ShowRoomDialogMessageResult(roomForm.DialogResult, false);
        }

        private void buttonEditRoom_Click(object sender, EventArgs e) {
            var room = IsSelectedRoomValid();

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

        private void buttonDeleteRoom_Click(object sender, EventArgs e) {
            var room = IsSelectedRoomValid();
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
                var index = ListViewRoom.SelectedItems[0].Index;
                if (index < Rooms.Count) {
                    var room = Rooms[index];
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

        private void buttonReloadRoom_Click(object sender, EventArgs e) {
            LoadRoomData();
            new ToastForm("Đã thực hiện tải lại dữ liệu chung cư").Show();
        }

        private void buttonAddResidentToRoom_Click(object sender, EventArgs e) {
            var room = IsSelectedRoomValid();
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

        private void buttonRemoveResidentFromRoom_Click(object sender, EventArgs e) {
            var room = IsSelectedRoomValid();

            if (ListViewRoomUserList.SelectedItems.Count > 0) {
                var name = ListViewRoomUserList.SelectedItems[0].Text;
                var email = ListViewRoomUserList.SelectedItems[0].SubItems[1].Text;
                var user = _userService.GetByNameAndEmail(name, email);

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

        private void ButtonRoomSearch_Click(object sender, EventArgs e)
        {
            string building = comboBoxRoomBuilding.SelectedIndex == 0 ? null : (string)comboBoxRoomBuilding.SelectedItem;
            RoomStatus state = RoomStatusExtensions.ToRoomStatus((string)comboBoxRoomState.SelectedItem);
            List<string> text = QueryUtils.ChangeSearchInput((string) comboBoxRoomSearch.SelectedItem, textBoxRoomSearch.Text);
            Rooms = _roomService.GetByCustomizeQuery(building, state, text);
            InsertRoomIntoListView(Rooms);
        }
        
        private void ButtonRoomContract_Click(object sender, EventArgs e)
        {
            var room = IsSelectedRoomValid();
            
            if (room == null)
            {
                new ToastForm("Vui lòng chọn căn hộ", true).Show();
                return;
            }

            Contract contract = _roomService.GetCurrentContract(room);
            
            if (contract == null)
            {
                new ToastForm("Không tìm thấy hợp đồng", true).Show();
                return;
            }
            
            new ContractInfomationForm(contract).Show();
        }
    }
}