using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;
using AccommodationManagerApp.Service;

namespace AccommodationManagerApp.Forms
{
    public partial class LoginForm : BaseForm
    {
        private readonly AuthenticationService _authenticationService;
        
        public LoginForm()
        {
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPass.Text;
            try
            {
                bool result = _authenticationService.Authenticate(email, password);
                if (result)
                {
                    SplashForm splashForm = new SplashForm();
                    splashForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập sai thông tin!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
