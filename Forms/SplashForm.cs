using System;
using System.Threading;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using Microsoft.Extensions.DependencyInjection;

namespace AccommodationManagerApp.Forms
{
    public partial class SplashForm : BaseForm
    {
        private readonly User _user;
        private readonly AuthenticationService _authenticationService;
        
        public SplashForm()
        {
            InitializeComponent();
            Cursor = Cursors.Arrow;
            progressBar.Value = 0;
            timerProgress.Start();
            
            
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            if (_authenticationService != null) _user = _authenticationService.CurrentUser;
            else {
                Dispose();
                
                var thread = new Thread(() => {
                    Application.Run(new NewLoginForm());
                }); 
                
                thread.SetApartmentState(ApartmentState.STA); 
                thread.Start(); 
            }
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 4;

            if (progressBar.Value < 100) return;

            timerProgress.Stop();
            
            Dispose();
                
            var thread = new Thread(() => {
                if (_user.Role != UserRole.Tenant) {
                    Application.Run(new MainForm());
                }
                else {
                    Application.Run(new ClientForm());
                }
            }); 
            
            thread.SetApartmentState(ApartmentState.STA); 
            thread.Start(); 
        }
    }
}