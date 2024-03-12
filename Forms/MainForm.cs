using System.Collections.Generic;
using AccommodationManagerApp.Service;
using System.Windows.Forms;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm : BaseForm {
        private readonly RoomService _roomService;
        private readonly BuildingService _buildingService;
        private List<Building> Buildings { get; set; }

        public MainForm() {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _buildingService = ServiceLocator.ServiceProvider.GetService(typeof(BuildingService)) as BuildingService;
            InitializeComponent();
            LoadData();
        }

        private void LoadData() {
            LoadRoomData();
            LoadBuildingData();
        }

        private void LoadBuildingData() {
            Buildings = _buildingService.GetAll();

            foreach (var building in Buildings) {
                ListViewItem item = new ListViewItem(building.Id.ToString());
                item.SubItems.Add(building.Name);
                item.SubItems.Add(building.CreatedAt.ToString("dd/MM/yyyy"));
                ListViewBuilding.Items.Add(item);
            }
        }

        private void LoadRoomData() {
            // var units = _roomService.GetAll();
            //
            // foreach (var unit in units) {
            //     ListViewItem item = new ListViewItem(unit.Id.ToString());
            //     item.SubItems.Add(unit.Name);
            //     item.SubItems.Add(unit.Building);
            //     item.SubItems.Add(unit.CreatedAt.ToString("dd/MM/yyyy"));
            //     ListViewUnit.Items.Add(item);
            // }
        }

        private void UnitListView_ItemActivate(object sender, System.EventArgs e) {
            // ListViewItem selectedItem = ListViewUnit.SelectedItems[0];
            //
            // string id = selectedItem.Text;
            // string name = selectedItem.SubItems[1].Text;
            // string building = selectedItem.SubItems[2].Text;
            //
            // RoomForm unitForm = new RoomForm(id, name, building);
            // unitForm.ShowDialog();
            //
            // if (unitForm.DialogResult == DialogResult.OK)
            // {
            //     ListViewUnit.Items.Clear();
            //     LoadRoomData();
            // }
        }

        private void exportPdfButton_Click(object sender, System.EventArgs e) {
            BillDetail billDetailForm = new BillDetail();
            billDetailForm.Show();
        }

        private void ListViewBuilding_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (ListViewBuilding.SelectedItems.Count > 0) {
                int index = ListViewBuilding.SelectedItems[0].Index;
                if (index < Buildings.Count) {
                    Building building = Buildings[index];

                    string id = building.Id.ToString();
                    string name = building.Name;
                    string address = building.Address;
                    string createdAt = building.CreatedAt.ToString("dd/MM/yyyy");

                    labelBuildingId.Text = id.Equals("") ? "Chưa có dữ liệu" : id;
                    labelBuildingName.Text = name == null || name.Equals("") ? "Chưa có dữ liệu" : name;
                    labelBuildingAddress.Text = address == null || address.Equals("") ? "Chưa có dữ liệu" : address;
                    labelBuilldingCreatedAt.Text = createdAt.Equals("") ? "Chưa có dữ liệu" : createdAt;
                }
            }
        }

        private void buttonEditBuilding_Click(object sender, System.EventArgs e) {
            if (ListViewBuilding.SelectedItems.Count > 0) {
                var index = ListViewBuilding.SelectedItems[0].Index;
                if (index < Buildings.Count)
                {
                    var building = Buildings[index];
                    var buildingForm = new BuildingForm(building);
                    buildingForm.ShowDialog();

                    ShowBuildingDialogMessageResult(buildingForm.DialogResult, true);

                    if (ListViewBuilding.Items.Count > index) {
                        ListViewBuilding.Items[index].Selected = true;
                        ListViewBuilding.Select();
                    }
                }
            }
            else {
                new ToastForm("Vui lòng chọn toà chung cư cần sửa", true).Show();
            }
        }

        private void buttonAddBuilding_Click(object sender, System.EventArgs e) {
            var buildingForm = new BuildingForm(null);
            buildingForm.ShowDialog();
            ShowBuildingDialogMessageResult(buildingForm.DialogResult, false);
        }

        private void ShowBuildingDialogMessageResult(DialogResult dialogResult, bool isEdit) {
            if (dialogResult == DialogResult.OK) {
                ListViewBuilding.Items.Clear();
                LoadBuildingData();
                if (isEdit) {
                    new ToastForm("Sửa thông tin toà chung cư thành công", false).Show();
                }
                else {
                    new ToastForm("Thêm thông tin toà chung cư mới thành công", false).Show();
                }
            }
            else {
                new ToastForm("Thêm thông tin toà chung cư mới thất bại", true).Show();
            }
        }

        private void buttonToast_Click(object sender, System.EventArgs e) {
            ToastForm toastForm = new ToastForm("Hello world!", true);
            toastForm.Show();
        }

        private void buttonDeleteBuilding_Click(object sender, System.EventArgs e) {
            if (ListViewBuilding.SelectedItems.Count > 0) {
                var index = ListViewBuilding.SelectedItems[0].Index;
                var building = Buildings[index];
                var confirmationForm = new ConfirmationForm("Bạn có chắc chắn muốn xóa toà chung cư này không?");
                var result = confirmationForm.ShowDialog();
                if (result == DialogResult.Yes) {
                    var deleteResult = _buildingService.Delete(building.Id);
                    if (deleteResult) {
                        ListViewBuilding.Items.Clear();
                        LoadBuildingData();
                        new ToastForm("Xóa toà chung cư thành công", false).Show();
                    }
                    else {
                        new ToastForm("Xóa toà chung cư thất bại", true).Show();
                    }
                }
            }
            else {
                new ToastForm("Vui lòng chọn toà chung cư cần xóa", true).Show();
            }
        }
    }
}