
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms
{
    public partial class ContractInfomationForm : BaseForm {
        public ContractInfomationForm(Contract contract)
        {
            InitializeComponent();
            
            SetUpData(contract);
        }

        private void SetUpData(Contract contract) {
            var tenantName = contract.User != null ? contract.User.Name : Resources.NullData;
            var roomNumber = contract.Room != null ? contract.Room.RoomNumber : Resources.NullData;
            var price = FormatText.IntegerToVnd(contract.Price);
            var startDate = string.IsNullOrEmpty(contract.StartDate.ToString())
                ? Resources.NullData
                : contract.StartDate.ToString("dd/MM/yyyy");
            var endDate = string.IsNullOrEmpty(contract.EndDate.ToString())
                ? Resources.NullData
                : contract.EndDate.ToString("dd/MM/yyyy");
            var isTerminated = contract.IsTerminated ? Resources.ContractTerminated : Resources.ContractInTime;

            labelContractTenantName.Text = tenantName;
            labelContractRoomNumber.Text = roomNumber;
            labelContractPrice.Text = price;
            labelContractStartDate.Text = startDate;
            labelContractEndDate.Text = endDate;
            labelContractIsTerminated.Text = isTerminated;
        }

        private void buttonClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}