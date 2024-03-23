using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class BuildingForm : BaseForm
    {
        private Building _building;
        private readonly BuildingService _buildingService;

        public BuildingForm(Building building)
        {
            _building = building;
            _buildingService = ServiceLocator.ServiceProvider.GetService(typeof(BuildingService)) as BuildingService;
            InitializeComponent();

            if (_building != null)
            {
                SetUpData();
            }
        }

        private void SetUpData()
        {
            textBoxName.Text = _building.Name;
            textBoxAddress.Text = _building.Address;
        }


        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (_building == null && _buildingService.IsBuildingNameExists(textBoxName.Text))
            {
                new ToastForm("Tên toà nhà đã tồn tại. Vui lòng nhập tên khác.", true).Show();
                return;
            }

            if (_building == null)
            {
                _buildingService.Add(new Building(textBoxName.Text, textBoxAddress.Text));
            }
            else
            {
                _building.Name = textBoxName.Text;
                _building.Address = textBoxAddress.Text;
                _buildingService.Update(_building.Id, _building);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BuildingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}