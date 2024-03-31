using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using AccommodationManagerApp.Forms;
using AccommodationManagerApp.Repository;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp {
    internal static class Program {
        private static ServiceProvider _serviceProvider;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            ConfigureServices();
            ActiveMigration();
            
            AuthenticationService authenticationService = _serviceProvider.GetService<AuthenticationService>();
            authenticationService.Authenticate("ngotanloi0709@gmail.com", "123");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new ClientForm());
            Application.Run(new MainForm());
        }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();

            // Others
            services.AddSingleton<AccommodationManagerAppContext>();

            // Services
            services.AddSingleton<AuthenticationService>();
            services.AddSingleton<UserService>();
            services.AddSingleton<RoomService>();
            services.AddSingleton<VehicleService>();
            services.AddSingleton<BuildingService>();
            services.AddSingleton<BillService>();
            services.AddSingleton<ContractService>();
            services.AddSingleton<RequestService>();

            // Repositories
            services.AddSingleton<BillRepository>();
            services.AddSingleton<UserRepository>();
            services.AddSingleton<RoomRepository>();
            services.AddSingleton<BuildingRepository>();
            services.AddSingleton<VehicleRepository>();
            services.AddSingleton<InitLogRepository>();
            services.AddSingleton<ContractRepository>();
            services.AddSingleton<RequestRepository>();

            _serviceProvider = services.BuildServiceProvider();
            ServiceLocator.Initialize(_serviceProvider);
        }

        private static void ActiveMigration() {
            new InitLog(_serviceProvider.GetService<InitLogRepository>());
        }
    }
}