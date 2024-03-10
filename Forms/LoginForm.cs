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
using AccommodationManagerApp.Models;
using AccommodationManagerApp.Repository;
using AccommodationManagerApp.Service;

namespace AccommodationManagerApp.Forms
{
    public partial class LoginForm : MaterialForm
    {
        private static ServiceProvider _serviceProvider;
        
        public LoginForm()
        {
            InitializeComponent();
            SetUpUi();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPass.Text;
            ConfigureServices();
            try
            {
                AuthenticationService authenticationService = _serviceProvider.GetService<AuthenticationService>();
                bool result = authenticationService.Authenticate(email, password);
                if (result)
                {
                    SplashForm splashForm = _serviceProvider.GetService<SplashForm>();
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

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();

            // Others
            services.AddSingleton<AccommodationManagerAppContext>();

            // Forms
            services.AddSingleton<MainForm>();
            services.AddSingleton<LoginForm>();
            services.AddSingleton<SplashForm>();

            // Services
            services.AddSingleton<AuthenticationService>();
            services.AddSingleton<UserService>();
            services.AddSingleton<UnitService>();

            // Repositories
            services.AddSingleton<UserRepository>();
            services.AddSingleton<UnitRepository>();
            services.AddSingleton<InitLogRepository>();

            _serviceProvider = services.BuildServiceProvider();
            ServiceLocator.Initialize(_serviceProvider);
        }
        // Set up UI
        private void SetUpUi()
        {
            Cursor = Cursors.Arrow;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700, Primary.Green700,
                Accent.LightBlue100, TextShade.WHITE);
        }
    }
}
