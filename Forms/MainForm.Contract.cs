using System;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
using AccommodationManagerApp.Util;
using Aspose.Words;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm {
        private void LoadContractData() {
            ListViewContract.Items.Clear();
            Contracts = _contractService.GetAllWithUserAndRoom();

            foreach (var contract in Contracts) {
                ListViewItem item = new ListViewItem(contract.User != null ? contract.User.Name : Resources.NullData);
                item.SubItems.Add(contract.Room != null ? contract.Room.RoomNumber : Resources.NullData);
                item.SubItems.Add(contract.Price.ToString());
                item.SubItems.Add(string.IsNullOrEmpty(contract.StartDate.ToString())
                    ? Resources.NullData
                    : contract.StartDate.ToString("dd/MM/yyyy"));
                if (_contractService.IsContractExpired(contract)) {
                    item.SubItems.Add(Resources.ContractTerminated);
                }
                else {
                    item.SubItems.Add(string.IsNullOrEmpty(contract.EndDate.ToString())
                        ? Resources.NullData
                        : contract.EndDate.ToString("dd/MM/yyyy"));
                }

                ListViewContract.Items.Add(item);
            }
        }

        private void buttonAddContract_Click(object sender, System.EventArgs e) {
            var contractForm = new ContractForm(null);
            contractForm.ShowDialog();
            ShowContractDialogMessageResult(contractForm.DialogResult, false);
        }

        private void buttonEditContract_Click(object sender, System.EventArgs e) {
            Contract contract = IsSelectedContractValid();
            
            if (contract != null) {
                if (contract.IsTerminated) {
                    new ToastForm("Hợp đồng đã kết thúc - bị thanh lý, không thể chỉnh sửa", true).Show();
                    return;
                }
                
                var contractForm = new ContractForm(contract);
                contractForm.ShowDialog();
                ShowContractDialogMessageResult(contractForm.DialogResult, true);
                SelectContractAgain(contract);
            }
            else {
                new ToastForm("Vui lòng chọn hợp đồng cần sửa", true).Show();
            }
        }

        private void SelectContractAgain(Contract contract) {
            int index = Contracts.IndexOf(contract);

            if (ListViewContract.Items.Count > index) {
                ListViewContract.Items[index].Selected = true;
                ListViewContract.Select();
            }
        }

        private void ShowContractDialogMessageResult(DialogResult dialogResult, bool isEdit) {
            string message;
            if (dialogResult == DialogResult.Cancel) {
                return;
            }

            if (dialogResult == DialogResult.OK) {
                DialogResult = DialogResult.OK;

                ContractForeignInformationReload();

                message = isEdit
                    ? "Sửa thông tin hợp đồng thành công"
                    : "Thêm thông tin hợp đồng thành công";
            }
            else {
                message = isEdit ? "Sửa thông tin hợp đồng thất bại" : "Thêm thông tin hợp đồng thất bại";
            }

            new ToastForm(message, dialogResult != DialogResult.OK).Show();
        }

        private void buttonTerminateContract_Click(object sender, System.EventArgs e) {
            Contract contract = IsSelectedContractValid();

            if (contract != null) {
                if (contract.IsTerminated) {
                    new ToastForm("Hợp đồng đã kết thúc - bị thanh lý", true).Show();
                    return;
                }
                
                var confirmationForm = new ConfirmationForm("Bạn có chắc chắn muốn kết thúc hợp đồng này không?");
                var result = confirmationForm.ShowDialog();

                if (result == DialogResult.Yes) {
                    _contractService.TerminateContract(contract);
                    ContractForeignInformationReload();
                    new ToastForm("Hợp đồng đã thanh lý").Show();
                }
            }
            else {
                new ToastForm("Vui lòng chọn hợp đồng cần thao tác", true).Show();
            }
        }

        private void buttonExtendContract_Click(object sender, System.EventArgs e) {
            Contract contract = IsSelectedContractValid();
            
            if (contract != null) {
                if (contract.IsTerminated) {
                    new ToastForm("Hợp đồng đã kết thúc - bị thanh lý, không thể gia hạn", true).Show();
                    return;
                }
                
                var contractForm = new ContractExtendForm(contract);
                contractForm.ShowDialog();
                
                if (contractForm.DialogResult == DialogResult.OK) {
                    ContractForeignInformationReload();
                    new ToastForm("Gia hạn hợp đồng thành công", false).Show();
                }
                
                SelectContractAgain(contract);
            }
            else {
                new ToastForm("Vui lòng chọn hợp đồng cần sửa", true).Show();
            }
        }

        private void ListViewContract_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
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

                labelContractTenantName.Text = tenantName;
                labelContractRoomNumber.Text = roomNumber;
                labelContractPrice.Text = price;
                labelContractStartDate.Text = startDate;
                labelContractEndDate.Text = endDate;
                labelContractIsTerminated.Text = isTerminated;
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

        private void buttonDelete_Click(object sender, System.EventArgs e) {
            Contract contract = IsSelectedContractValid();

            if (contract != null) {
                var confirmationForm = new ConfirmationForm("Bạn có chắc chắn muốn xóa hợp đồng này không?");
                var result = confirmationForm.ShowDialog();

                if (result == DialogResult.Yes) {
                    var deleteResult = _contractService.Delete(contract.Id);

                    if (deleteResult) {
                        ContractForeignInformationReload();
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
        
        private void ContractForeignInformationReload() {
            LoadContractData();
            LoadUserData();
            LoadRoomData();
        }
        
        private void buttonReloadContract_Click(object sender, System.EventArgs e)
        {
            ContractForeignInformationReload();
            new ToastForm("Đã thực hiện tải lại dữ liệu hợp đồng").Show();
        }

        private void btnWordExtract_Click(object sender, System.EventArgs e)
        {
            Contract contract = IsSelectedContractValid();
            if (contract != null)
            {
                string date = DateTime.Now.ToString("dd/MM/yyyy");
                string tenantName = contract.User != null ? contract.User.Name : Resources.NullData;
                string tenantIdentityNumber = contract.User != null ? contract.User.IdentityNumber : Resources.NullData;
                string tenantPhone = contract.User != null ? contract.User.Phone : Resources.NullData;
                string dateOfBirth = contract.User != null ? contract.User.DateOfBirth.ToString("dd/MM/yyyy") : Resources.NullData;
                string roomNumber = contract.Room != null ? contract.Room.RoomNumber : Resources.NullData;
                string price = FormatText.IntegerToVnd(contract.Price);
                string startDate = string.IsNullOrEmpty(contract.StartDate.ToString())
                    ? Resources.NullData
                    : contract.StartDate.ToString("dd/MM/yyyy");
                string endDate = string.IsNullOrEmpty(contract.EndDate.ToString())
                    ? Resources.NullData
                    : contract.EndDate.ToString("dd/MM/yyyy");
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "DOC Files|*.docx";
                saveFileDialog.Title = "Save as DOCX";
                saveFileDialog.FileName = "Contract.docx";
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    try
                    {
                        Document doc = new Document("..\\..\\Template\\contract.docx");
                        doc.MailMerge.Execute(new string[] { "This_Date" }, new[] { date });
                        doc.MailMerge.Execute(new string[] { "Tennant_Name" }, new[] { tenantName });
                        doc.MailMerge.Execute(new string[] { "Tennant_CCCD" }, new[] { tenantIdentityNumber });
                        doc.MailMerge.Execute(new string[] { "Tennant_Phone" }, new[] { tenantPhone });
                        doc.MailMerge.Execute(new string[] { "Date_of_Birth" }, new[] { dateOfBirth });
                        doc.MailMerge.Execute(new string[] { "Room_Number" }, new[] { roomNumber });
                        doc.MailMerge.Execute(new string[] { "Single_Price" }, new[] { price });
                        doc.MailMerge.Execute(new string[] { "Start_Date" }, new[] { startDate });
                        doc.MailMerge.Execute(new string[] { "End_Date" }, new[] { endDate });
                        doc.Save(filePath);
                        MessageBox.Show("Xuất Word thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất Word: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }   
            }
            else 
            {
                new ToastForm("Vui lòng chọn hợp đồng cần xuất", true).Show();
            }
        }
    }
}