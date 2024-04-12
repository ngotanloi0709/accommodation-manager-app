using AccommodationManagerApp.Model;
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
    public partial class ViewUserRoomInfor : BaseForm

    {
        private User _user;
        public ViewUserRoomInfor(User user)
        {
            _user = user;
            InitializeComponent();
        }
    }
}
