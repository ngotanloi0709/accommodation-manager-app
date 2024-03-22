using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm {
        private void LoadBuildingData() {
            ListViewBuilding.Items.Clear();
            Buildings = _buildingService.GetAll();

            foreach (var building in Buildings) {
                ListViewItem item = new ListViewItem(string.IsNullOrEmpty(building.Name) ? Resources.NullData : building.Name);
                item.SubItems.Add(string.IsNullOrEmpty(building.Address) ? Resources.NullData : building.Address);
                item.SubItems.Add(building.CreatedAt.ToString("dd/MM/yyyy"));
                ListViewBuilding.Items.Add(item);
            }
        }

        private void ListViewBuilding_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            Building building = IsSelectedBuildingValid();

            if (building != null) {
                string id = building.Id.ToString();
                string name = building.Name;
                string address = building.Address;
                string createdAt = building.CreatedAt.ToString("dd/MM/yyyy");

                labelBuildingId.Text = id.Equals("") ? Resources.NullData : id;
                labelBuildingName.Text = name == null || name.Equals("") ? Resources.NullData : name;
                labelBuildingAddress.Text = address == null || address.Equals("") ? Resources.NullData : address;
                labelBuilldingCreatedAt.Text = createdAt.Equals("") ? Resources.NullData : createdAt;
            }
        }

        private void buttonEditBuilding_Click(object sender, System.EventArgs e) {
            Building building = IsSelectedBuildingValid();

            if (building != null) {
                var buildingForm = new BuildingForm(building);

                buildingForm.ShowDialog();
                ShowBuildingDialogMessageResult(buildingForm.DialogResult, true);
                SelectBuildingAgain(building);
            }
            else {
                new ToastForm("Vui lòng chọn toà chung cư ", true).Show();
            }
        }

        private void buttonAddBuilding_Click(object sender, System.EventArgs e) {
            var buildingForm = new BuildingForm(null);
            buildingForm.ShowDialog();
            ShowBuildingDialogMessageResult(buildingForm.DialogResult, false);
        }

        private void ShowBuildingDialogMessageResult(DialogResult dialogResult, bool isEdit) {
            string message;
            
            if (dialogResult == DialogResult.Cancel) {
                return;
            }
            
            if (dialogResult == DialogResult.OK) {
                if (isEdit) {
                    BuildingForeignInformationReload();
                }
                else {
                    LoadBuildingData();
                }
                
                message = isEdit
                    ? "Sửa thông tin toà chung cư thành công"
                    : "Thêm thông tin toà chung cư mới thành công";
            }
            else {
                message = isEdit ? "Sửa thông tin toà chung cư thất bại" : "Thêm thông tin toà chung cư mới thất bại";
            }
            
            new ToastForm(message, dialogResult != DialogResult.OK).Show();
        }

        private void buttonDeleteBuilding_Click(object sender, System.EventArgs e) {
            Building building = IsSelectedBuildingValid();

            if (building != null) {
                var confirmationForm = new ConfirmationForm("Bạn có chắc chắn muốn xóa toà chung cư này không?");
                var result = confirmationForm.ShowDialog();

                if (result == DialogResult.Yes) {
                    if (_buildingService.Delete(building.Id)) {
                        BuildingForeignInformationReload();
                        new ToastForm("Xóa toà chung cư thành công", false).Show();
                    }
                    else {
                        new ToastForm("Xóa toà chung cư thất bại", true).Show();
                    }
                }
            } 
            else {
                new ToastForm("Vui lòng chọn toà chung cư ", true).Show();
            }
        }

        private Building IsSelectedBuildingValid() {
            if (ListViewBuilding.SelectedItems.Count > 0) {
                int index = ListViewBuilding.SelectedItems[0].Index;
                if (index < Buildings.Count) {
                    return Buildings[index];
                }
            }
            
            return null;
        }

        private void SelectBuildingAgain(Building building) {
            var index = Buildings.IndexOf(building);

            if (ListViewBuilding.Items.Count > index) {
                ListViewBuilding.Items[index].Selected = true;
                ListViewBuilding.Select();
            }
        }

        private void BuildingForeignInformationReload() {
            LoadBuildingData();
            LoadRoomData();
            LoadUserData();
        }
        
        private void buttonReloadBuilding_Click(object sender, System.EventArgs e)
        {
            LoadBuildingData();
            new ToastForm("Đã thực hiện tải lại dữ liệu toà nhà", false).Show();
        }

    }
}
