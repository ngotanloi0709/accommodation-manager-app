using System;
using System.Globalization;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;

namespace AccommodationManagerApp.Forms {
    public partial class ContractExtendForm : BaseForm {
        private Contract _contract;
        private readonly ContractService _contractService;

        public ContractExtendForm(Contract contract) {
            _contract = contract;
            _contractService = ServiceLocator.ServiceProvider.GetService(typeof(ContractService)) as ContractService;
            
            InitializeComponent();

            if (_contract == null) {
                new ToastForm("Đã có lỗi xảy ra. Vui lòng thử lại", true).Show();
                Close();
            }

            SetUpComboBox();
            SetUpData();
        }
        
        private void SetUpComboBox() {
            comboBoxMonth.Items.Add("None");
            comboBoxMonth.Items.Add("1 tháng");
            comboBoxMonth.Items.Add("3 tháng");
            comboBoxMonth.Items.Add("6 tháng");
            comboBoxMonth.Items.Add("12 tháng");
            comboBoxMonth.Items.Add("18 tháng");
            comboBoxMonth.Items.Add("24 tháng");
            comboBoxMonth.Items.Add("36 tháng");
            
            comboBoxMonth.SelectedIndex = 0;
        }

        private void SetUpData() {
            labelTenantName.Text = _contract.User.Name;
            labelRoomNumber.Text = _contract.Room.RoomNumber;
            
            dateTimePickerContractStartDate.Value = _contract.StartDate;
            dateTimePickerContractStartDate.Enabled = false;
            
            
        }

        private void ButtonSave_Click(object sender, EventArgs e) {
            _contract.EndDate = DateTime.ParseExact(labelContractEndDate.Text, "dd/MM/yyyy", CultureInfo.CurrentCulture);
            _contractService.Update(_contract);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMonth.Text.Equals("None"))
            {
                labelContractEndDate.Text = _contract.EndDate.ToString("dd/MM/yyyy");
                return;
            }

            var months = int.Parse(comboBoxMonth.Text.Split(' ')[0]);
            var endDate = _contract.EndDate.AddMonths(months);
            labelContractEndDate.Text = endDate.ToString("dd/MM/yyyy");
        }
    }
}