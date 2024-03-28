using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
using AccommodationManagerApp.Service;
using System.Collections.Generic;
using System.Windows.Forms;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms
{
    public partial class ContractManagementForm : BaseForm
    {
        private readonly ContractService _contractService;
        private List<Contract> Contracts { get; set; }

        public ContractManagementForm()
        {
            _contractService = ServiceLocator.ServiceProvider.GetService(typeof(ContractService)) as ContractService;

            InitializeComponent();

            LoadData();

            ListViewContract.GridLines = true;
        }

        private void LoadData()
        {
            ListViewContract.Items.Clear();
            Contracts = _contractService.GetAllWithUserAndRoom();

            foreach (var contract in Contracts)
            {
                ListViewItem item = new ListViewItem(contract.User != null ? contract.User.Name : Resources.NullData);
                item.SubItems.Add(contract.Room != null ? contract.Room.RoomNumber : Resources.NullData);
                item.SubItems.Add(contract.Price.ToString());
                item.SubItems.Add(string.IsNullOrEmpty(contract.StartDate.ToString())
                    ? Resources.NullData
                    : contract.StartDate.ToString("dd/MM/yyyy"));
                if (_contractService.IsContractExpired(contract))
                {
                    item.SubItems.Add(Resources.ContractTerminated);
                }
                else
                {
                    item.SubItems.Add(string.IsNullOrEmpty(contract.EndDate.ToString())
                        ? Resources.NullData
                        : contract.EndDate.ToString("dd/MM/yyyy"));
                }

                ListViewContract.Items.Add(item);
            }
        }

        private void buttonAddContract_Click(object sender, System.EventArgs e)
        {
            var contractForm = new ContractForm(null);
            contractForm.ShowDialog();
            ShowContractDialogMessageResult(contractForm.DialogResult, false);
        }

        private void buttonEditContract_Click(object sender, System.EventArgs e) { }

        private void ShowContractDialogMessageResult(DialogResult dialogResult, bool isEdit)
        {
            string message;
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            if (dialogResult == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;

                LoadData();

                message = isEdit
                    ? "Sửa thông tin hợp đồng thành công"
                    : "Thêm thông tin hợp đồng thành công";
            }
            else
            {
                message = isEdit ? "Sửa thông tin hợp đồng thất bại" : "Thêm thông tin hợp đồng thất bại";
            }

            new ToastForm(message, dialogResult != DialogResult.OK).Show();
        }


        private void buttonTerminateContract_Click(object sender, System.EventArgs e) { }

        private void buttonExtendContract_Click(object sender, System.EventArgs e) { }

        private void ListViewContract_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Contract contract = IsSelectedContractValid();
            
            if (contract != null) {
                string tenantName = contract.User != null ? contract.User.Name : Resources.NullData;
                string roomNumber = contract.Room != null ? contract.Room.RoomNumber : Resources.NullData;
                string price = FormatText.IntegerToVnd(contract.Price);
                string startDate = string.IsNullOrEmpty(contract.StartDate.ToString())
                    ? Resources.NullData
                    : contract.StartDate.ToString("dd/MM/yyyy");
                string endDate = string.IsNullOrEmpty(contract.EndDate.ToString())
                    ? Resources.NullData
                    : contract.EndDate.ToString("dd/MM/yyyy");
                string isTerminated = contract.IsTerminated ? Resources.ContractTerminated : Resources.ContractInTime;
                
                labelTenantName.Text = tenantName;
                labelRoomNumber.Text = roomNumber;
                labelPrice.Text = price;
                labelStartDate.Text = startDate;
                labelEndDate.Text = endDate;
                labelIsTerminated.Text = isTerminated;
            }
        }

        private Contract IsSelectedContractValid() {
            if (ListViewContract.SelectedItems.Count > 0) {
                int index = ListViewContract.SelectedItems[0].Index;
                if (index < Contracts.Count) {
                    Contract contract = Contracts[index];
                    return contract;
                }
            }

            return null;
        }

        private void buttonDelete_Click(object sender, System.EventArgs e)
        {
            Contract contract = IsSelectedContractValid();
            if (contract != null) {
                var confirmationForm = new ConfirmationForm("Bạn có chắc chắn muốn xóa hợp đồng này không?");
                var result = confirmationForm.ShowDialog();
                if (result == DialogResult.Yes) {
                    var deleteResult = _contractService.Delete(contract.Id);
                    if (deleteResult) {
                        LoadData();
                        new ToastForm("Xóa thông tin hợp đồng thành công", false).Show();
                    }
                    else {
                        new ToastForm("Xóa thông tin hợp đồng thất bại", true).Show();
                    }
                }
            }
            else {
                new ToastForm("Vui lòng chọn hợp đồng cần xóa", true).Show();
            }
        }
    }
}