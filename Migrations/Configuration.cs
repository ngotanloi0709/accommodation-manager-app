using MySql.Data.EntityFramework;
using System.Data.Entity.Migrations;
using System.Linq;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Migrations {
    internal sealed class Configuration : DbMigrationsConfiguration<Repository.AccommodationManagerAppContext> {
        public Configuration() {
            SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationSqlGenerator());
            
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
        
        protected override void Seed(Repository.AccommodationManagerAppContext context) {
            if (!context.Users.Any())
            {
                context.Users.AddOrUpdate(new User("ngotanloi0709@gmail.com", "Judian Ngo", PasswordHelper.HashPassword("123")));
            }
            
            if (!context.Buildings.Any())
            {
                context.Buildings.AddOrUpdate(new Building { Name = "Building 1" });
                context.Buildings.AddOrUpdate(new Building { Name = "Building 2" });
                context.Buildings.AddOrUpdate(new Building { Name = "Building 3" });
            }   
        }
    }
}