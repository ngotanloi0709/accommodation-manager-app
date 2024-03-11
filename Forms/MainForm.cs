using AccommodationManagerApp.Service;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using TenantManagementSystem.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class MainForm : MaterialForm
    {
        private readonly RoomService _roomService;
        private readonly BuildingService _buildingService;

        public MainForm()
        {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _buildingService = ServiceLocator.ServiceProvider.GetService(typeof(BuildingService)) as BuildingService;
            InitializeComponent();
            SetUpUi();
            LoadData();
        }

        private void SetUpUi()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700, Primary.Green700,
                Accent.Purple400, TextShade.WHITE);
        }

        private void LoadData()
        {
            LoadRoomData();
            LoadBuildingData();
        }

        private void LoadBuildingData()
        {
            var buildings = _buildingService.GetAll();
            //
            foreach (var building in buildings)
            {
                ListViewItem item = new ListViewItem(building.Id.ToString());
                item.SubItems.Add(building.Name);
                item.SubItems.Add(building.CreatedAt.ToString("dd/MM/yyyy"));
                ListViewBuilding.Items.Add(item);
            }
        }

        private void LoadRoomData()
        {
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

        private void UnitListView_ItemActivate(object sender, System.EventArgs e)
        {
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

        private void exportPdfButton_Click(object sender, System.EventArgs e)
        {
            BillDetail billDetailForm = new BillDetail();
            billDetailForm.Show();
        }

        private void ListViewBuilding_MouseClick(object sender, MouseEventArgs e)
        {
            labelBuildingId.Text = ListViewBuilding.SelectedItems[0].Text;
            labelBuildingName.Text = ListViewBuilding.SelectedItems[0].SubItems[1].Text;
            // labelBuildingAddress = ListViewBuilding.SelectedItems[0].SubItems[2].Text;
            labelBuilldingCreatedAt.Text = ListViewBuilding.SelectedItems[0].SubItems[2].Text;
            
        }

        private void buttonEditBuilding_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonAddBuilding_Click(object sender, System.EventArgs e)
        {

        }
    }
}