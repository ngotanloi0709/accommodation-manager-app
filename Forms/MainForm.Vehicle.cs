using System;
using System.Runtime.Serialization;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;

namespace AccommodationManagerApp.Forms
{
    public partial class MainForm
    {
        private void LoadVehicleData() { 
            ListViewVehicle.Items.Clear();
            Vehicles = _vehicleService.GetAll();
            foreach (var vehicle in Vehicles)
            {
                ListViewItem item = new ListViewItem(vehicle.number);
                item.SubItems.Add(vehicle.name);
                item.SubItems.Add(vehicle.type);
                ListViewVehicle.Items.Add(item);
            }
        }
        private void ListViewVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehicle vehicle = IsSelectedVehicleValid();
            if(vehicle != null)
            {
                string  id = vehicle.Id.ToString();
                string number = vehicle.number;
                string name = vehicle.name;
                string type = vehicle.type;
                labelVehicleId.Text = id.Equals("") ? Resources.NullData : id;
                labelVehicleNumber.Text = number == null || number.Equals("") ? Resources.NullData : number;
                labelVehicleName.Text = name == null || name.Equals("") ? Resources.NullData : name;
                labelVehicleType.Text = type == null || type.Equals("") ? Resources.NullData : type;
            }
        }
        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {

            var vehicleForm = new VehicleForm(null);
            vehicleForm.ShowDialog();
            ShowVehicleDialogMessageResult(vehicleForm.DialogResult, false);
        }

        private void ShowVehicleDialogMessageResult(DialogResult dialogResult, bool v)
        {
            throw new NotImplementedException();
        }

        private Vehicle IsSelectedVehicleValid()
        {
            if(ListViewVehicle.SelectedItems.Count > 0)
            {
                int index = ListViewVehicle.SelectedItems[0].Index;
                if(index >= 0 && index < Vehicles.Count)
                {
                    return Vehicles[index];
                }
            }
            return null;
        }
    }
}
