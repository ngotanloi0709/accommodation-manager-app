using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using AccommodationManagerApp.Service;
using TenantManagementSystem.Forms;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm : MaterialForm {
        private readonly UnitService _unitService;

        public MainForm() {
            _unitService = ServiceLocator.ServiceProvider.GetService(typeof(UnitService)) as UnitService;
            InitializeComponent();
            SetUpUi();
            LoadData();
        }

        private void SetUpUi() {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700, Primary.Green700,
                Accent.Purple400, TextShade.WHITE);
        }

        private void LoadData() {
            LoadUnitData();
        }

        private void LoadUnitData() {
            var units = _unitService.GetAll();

            foreach (var unit in units) {
                ListViewItem item = new ListViewItem(unit.Id.ToString());
                item.SubItems.Add(unit.Name);
                item.SubItems.Add(unit.Building);
                item.SubItems.Add(unit.CreatedAt.ToString("dd/MM/yyyy"));
                ListViewUnit.Items.Add(item);
            }
        }

        private void UnitListView_ItemActivate(object sender, System.EventArgs e) {
            ListViewItem selectedItem = ListViewUnit.SelectedItems[0];

            string id = selectedItem.Text;
            string name = selectedItem.SubItems[1].Text;
            string building = selectedItem.SubItems[2].Text;

            UnitForm unitForm = new UnitForm(id, name, building);
            unitForm.ShowDialog();

            if (unitForm.DialogResult == DialogResult.OK) {
                ListViewUnit.Items.Clear();
                LoadUnitData();
            }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}