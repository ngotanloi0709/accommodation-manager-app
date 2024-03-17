using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class VehicleForm : BaseForm
    {
        private Vehicle _vehicle; 
        private readonly VehicleService _vehicleService;
        public VehicleForm(Vehicle vehicle)
        {
            _vehicle = vehicle;
            _vehicleService = ServiceLocator.ServiceProvider.GetService(typeof(VehicleService)) as VehicleService;
            InitializeComponent();
            if(_vehicle != null)
            {
                setUpData();
            }
        }

        private void setUpData()
        {
            textBoxType.Text = _vehicle.type;
            textBoxName.Text = _vehicle.name;
            textBoxNumber.Text = _vehicle.number;
        }
    }
}
