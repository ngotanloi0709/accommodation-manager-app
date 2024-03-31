using System;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm {
        private void LoadVehicleData() {
            ListViewVehicle.Items.Clear();
            Vehicles = _vehicleService.GetAllWithRoom();
            foreach (var vehicle in Vehicles) {
                ListViewItem item = new ListViewItem(vehicle.Number);
                item.SubItems.Add(vehicle.Name);
                item.SubItems.Add(vehicle.Category.ToVietnamese().ToString());
                if (vehicle.Room != null) {
                    item.SubItems.Add(vehicle.Room.RoomNumber);
                }
                else {
                    item.SubItems.Add(Resources.NullData);
                }

                ListViewVehicle.Items.Add(item);
            }
        }

        private void ListViewVehicle_SelectedIndexChanged(object sender, EventArgs e) {
            Vehicle vehicle = IsSelectedVehicleValid();
            if (vehicle != null) {
                string number = vehicle.Number;
                string name = vehicle.Name;
                string price = FormatText.IntegerToVnd(vehicle.Price);
                string type = VehicleCategoryExtensions.ToVietnamese(vehicle.Category);
                string roomNumber = vehicle.Room != null ? vehicle.Room.RoomNumber : Resources.NullData;
                labelVehicleNumber.Text = string.IsNullOrEmpty(number) ? Resources.NullData : number;
                labelVehicleName.Text = string.IsNullOrEmpty(name) ? Resources.NullData : name;
                lableVehiclePrice.Text = string.IsNullOrEmpty(price) ? Resources.NullData : price;
                labelVehicleType.Text = string.IsNullOrEmpty(type) ? Resources.NullData : type;
                labelVehicleRoom.Text = string.IsNullOrEmpty(roomNumber) ? Resources.NullData : roomNumber;
            }
        }

        private void buttonAddVehicle_Click(object sender, EventArgs e) {
            var vehicleForm = new VehicleForm(null);
            vehicleForm.ShowDialog();
            ShowVehicleDialogMessageResult(vehicleForm.DialogResult, false);
        }

        private void buttonEditVehicle_Click(object sender, EventArgs e) {
            Vehicle vehicle = IsSelectedVehicleValid();
            if (vehicle != null) {
                var vehicleForm = new VehicleForm(vehicle);
                vehicleForm.ShowDialog();
                ShowVehicleDialogMessageResult(vehicleForm.DialogResult, true);
                SelectedVehicleAgain(vehicle);
            }
            else {
                new ToastForm("Vui lòng chọn phương tiện", true).Show();
            }
        }

        private void SelectedVehicleAgain(Vehicle vehicle) {
            var index = Vehicles.IndexOf(vehicle);
            if (ListViewVehicle.Items.Count > index) {
                ListViewVehicle.Items[index].Selected = true;
                ListViewVehicle.Select();
            }
        }

        private void buttonDeleteVehicle_Click(object sender, EventArgs e) {
            Vehicle vehicle = IsSelectedVehicleValid();
            if (vehicle != null) {
                var confirmation = new ConfirmationForm("Xác nhận xóa phương tiện?");
                var result = confirmation.ShowDialog();
                if (result == DialogResult.Yes) {
                    if (_vehicleService.Delete(vehicle.Id)) {
                        VehicleForeignInformationReload();
                        new ToastForm("Xóa phương tiện thành công", false).Show();
                    }
                    else {
                        new ToastForm("Xóa phương tiện thất bại", true).Show();
                    }
                }
            }
            else {
                new ToastForm("Vui lòng chọn phương tiện cần xóa", true).Show();
            }
        }

        private void ShowVehicleDialogMessageResult(DialogResult dialogResult, bool v) {
            string message;
            if (dialogResult == DialogResult.Cancel) {
                return;
            }

            if (dialogResult == DialogResult.OK) {
                if (v) {
                    VehicleForeignInformationReload();
                }
                else {
                    LoadVehicleData();
                }

                message = v ? "Cập nhật thông tin phương tiện thành công" : "Thêm phương tiện thành công";
            }
            else {
                message = v ? "Cập nhật thông tin phương tiện thất bại" : "Thêm phương tiện thất bại";
            }

            new ToastForm(message, dialogResult != DialogResult.OK).Show();
        }

        private void VehicleForeignInformationReload() {
            LoadVehicleData();
            LoadRoomData();
        }

        private Vehicle IsSelectedVehicleValid() {
            if (ListViewVehicle.SelectedItems.Count > 0) {
                int index = ListViewVehicle.SelectedItems[0].Index;
                if (index >= 0 && index < Vehicles.Count) {
                    return Vehicles[index];
                }
            }

            return null;
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e) {
            LoadVehicleData();
            new ToastForm("Dữ liệu phương tiện đã được tải lại", false).Show();
        }
    }
}