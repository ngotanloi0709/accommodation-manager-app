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
            
            // Test();
            AuthenticationService authenticationService = _serviceProvider.GetService<AuthenticationService>();
            authenticationService.Authenticate("ngotanloi0709@gmail.com", "1234");
            // Console.WriteLine(authenticationService.IsAuthenticated());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            // Application.Run(new SplashForm());
            // Application.Run(new LoginForm());
            //Application.Run(new BillDetail());
        }

        private static void Test() {
            RoomService roomService = _serviceProvider.GetService<RoomService>();
            BuildingService buildingService = _serviceProvider.GetService<BuildingService>();
            // Building building = buildingService.GetById(2);
            // Room room = new Room(null, "A101", null, building, RoomStatus.Empty);
            // roomService.Add(room);
            // Room room = roomService.GetByIdWithBuilding(1);
            // room.Status = RoomStatus.Rented;
            // Console.WriteLine(room);
            // roomService.Update(1, room);
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

            // Repositories
            services.AddSingleton<UserRepository>();
            services.AddSingleton<RoomRepository>();
            services.AddSingleton<BuildingRepository>();
            services.AddSingleton<VehicleRepository>();
            services.AddSingleton<InitLogRepository>();

            _serviceProvider = services.BuildServiceProvider();
            ServiceLocator.Initialize(_serviceProvider);
        }

        private static void ActiveMigration() {
            new InitLog(_serviceProvider.GetService<InitLogRepository>());
        }
    }
}