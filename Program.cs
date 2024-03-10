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

            // AuthenticationService authenticationService = _serviceProvider.GetService<AuthenticationService>();
            // authenticationService.Authenticate("ngotanloi0709@gmail.com", "123");
            // Console.WriteLine(authenticationService.IsAuthenticated());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(_serviceProvider.GetService<MainForm>());
            // Application.Run(new LoginForm());
            Application.Run(new BillDetail());
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

        private static void ActiveMigration() {
            new InitLog(_serviceProvider.GetService<InitLogRepository>());
        }
    }
}