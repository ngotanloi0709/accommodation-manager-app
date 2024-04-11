using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using AccommodationManagerApp.Forms;
using AccommodationManagerApp.Repository;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;
using MaterialSkin;

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
            SetUpTheme();
            
            var authenticationService = _serviceProvider.GetService<AuthenticationService>();
            authenticationService.Authenticate("ngotanloi0709@gmail.com", "123");
            // authenticationService.Authenticate("user1@gmail.com", "123");
            
            // ứng dụng này khó có khả năng chạy song song client và manager form, chỉ chạy 1 form mỗi lần 
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
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
            services.AddSingleton<ResponseService>();
            // Repositories
            services.AddSingleton<BillRepository>();
            services.AddSingleton<UserRepository>();
            services.AddSingleton<RoomRepository>();
            services.AddSingleton<BuildingRepository>();
            services.AddSingleton<VehicleRepository>();
            services.AddSingleton<InitLogRepository>();
            services.AddSingleton<ContractRepository>();
            services.AddSingleton<RequestRepository>();
            services.AddSingleton<ResponseRepository>();
            services.AddSingleton<FixedPriceRepository>();

            _serviceProvider = services.BuildServiceProvider();
            ServiceLocator.Initialize(_serviceProvider);
        }

        private static void SetUpTheme() {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700, Primary.Green700,
                Accent.Amber700, TextShade.WHITE);
        }

        private static void ActiveMigration() {
            new InitLog(_serviceProvider.GetService<InitLogRepository>());
        }
    }
}