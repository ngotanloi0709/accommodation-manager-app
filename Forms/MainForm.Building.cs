using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm {
        private void LoadBuildingData()
        {
            Buildings = _buildingService.GetAll();

            foreach (var building in Buildings)
            {
                ListViewItem item = new ListViewItem(building.Id.ToString());
                item.SubItems.Add(building.Name);
                item.SubItems.Add(building.CreatedAt.ToString("dd/MM/yyyy"));
                ListViewBuilding.Items.Add(item);
            }
        }
        
        private void ListViewBuilding_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (ListViewBuilding.SelectedItems.Count > 0)
            {
                int index = ListViewBuilding.SelectedItems[0].Index;
                if (index < Buildings.Count)
                {
                    Building building = Buildings[index];

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
        }

        private void buttonEditBuilding_Click(object sender, System.EventArgs e)
        {
            if (ListViewBuilding.SelectedItems.Count > 0)
            {
                var index = ListViewBuilding.SelectedItems[0].Index;
                if (index < Buildings.Count)
                {
                    var building = Buildings[index];
                    var buildingForm = new BuildingForm(building);
                    buildingForm.ShowDialog();

                    ShowBuildingDialogMessageResult(buildingForm.DialogResult, true);

                    if (ListViewBuilding.Items.Count > index)
                    {
                        ListViewBuilding.Items[index].Selected = true;
                        ListViewBuilding.Select();
                    }
                }
            }
            else
            {
                new ToastForm("Vui lòng chọn toà chung cư cần sửa", true).Show();
            }
        }

        private void buttonAddBuilding_Click(object sender, System.EventArgs e)
        {
            var buildingForm = new BuildingForm(null);
            buildingForm.ShowDialog();
            ShowBuildingDialogMessageResult(buildingForm.DialogResult, false);
        }

        private void ShowBuildingDialogMessageResult(DialogResult dialogResult, bool isEdit)
        {
            string message;
            if (dialogResult == DialogResult.OK)
            {
                ListViewBuilding.Items.Clear();
                LoadBuildingData();
                message = isEdit ? "Sửa thông tin toà chung cư thành công" : "Thêm thông tin toà chung cư mới thành công";
            }
            else
            {
                message = isEdit ? "Sửa thông tin toà chung cư thất bại" : "Thêm thông tin toà chung cư mới thất bại";
            }
            new ToastForm(message, dialogResult != DialogResult.OK).Show();
        }

        private void buttonDeleteBuilding_Click(object sender, System.EventArgs e)
        {
            if (ListViewBuilding.SelectedItems.Count > 0)
            {
                var index = ListViewBuilding.SelectedItems[0].Index;
                var building = Buildings[index];
                var confirmationForm = new ConfirmationForm("Bạn có chắc chắn muốn xóa toà chung cư này không?");
                var result = confirmationForm.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    var deleteResult = _buildingService.Delete(building.Id);
                    if (deleteResult)
                    {
                        ListViewBuilding.Items.Clear();
                        LoadBuildingData();
                        new ToastForm("Xóa toà chung cư thành công", false).Show();
                    }
                    else
                    {
                        new ToastForm("Xóa toà chung cư thất bại", true).Show();
                    }
                }
            }
            else
            {
                new ToastForm("Vui lòng chọn toà chung cư cần xóa", true).Show();
            }
        }
    }
}