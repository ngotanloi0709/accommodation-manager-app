using AccommodationManagerApp.Forms;
using AccommodationManagerApp.Service;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TenantManagementSystem.Forms
{
    public partial class RoomForm : BaseForm
    {
        private readonly RoomService _roomService;
        private int _unitId;
        
        public RoomForm(string Id, string Name, string Building)
        {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            InitializeComponent();
            SetUpData(Id, Name, Building);
        }
        
        private void SetUpData(string Id, string Name, string Building) {
            if (Id == null || Id.Equals("")) {
                ButtonDelete.Visible = false;
            } else {
                _unitId = int.Parse(Id);
            }
            
            TextBoxName.Text = Name;
            TextBoxBuilding.Text = Building;
        }

        private void ButtonDelete_Click(object sender, System.EventArgs e)
        {
            _roomService.Delete(_unitId);
            
            CloseForm();
        }

        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            if (_unitId == 0) {
                // _roomService.Add(TextBoxName.Text, TextBoxBuilding.Text);
            } else {
                // _roomService.Update(_unitId, TextBoxName.Text, TextBoxBuilding.Text);
            }
            
            CloseForm();
        }

        

        private void ButtonClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        
        private void CloseForm() {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}