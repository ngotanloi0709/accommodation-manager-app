using System;
using System.Data.Entity;
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
            DeleteAllTriggers(context);
            CreateBuildingDeleteTrigger(context);
            
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
            if (!context.Bills.Any())
            {
                context.Bills.AddOrUpdate(new Bill(1000, 887, 206, null));
                context.Bills.AddOrUpdate(new Bill(1500, 621, 372, null));
                context.Bills.AddOrUpdate(new Bill(2000, 913, 455, null));
            }  
        }
        
        private void CreateBuildingDeleteTrigger(DbContext context) {
            try
            {
                string createTriggerSql = @"
                    CREATE TRIGGER SetNullOnBuildingDelete
                    AFTER DELETE ON buildings
                    FOR EACH ROW
                    BEGIN
                        UPDATE rooms SET BuildingId = NULL WHERE BuildingId = OLD.Id;
                    END;
                    ";
                context.Database.ExecuteSqlCommand(createTriggerSql);
                Console.WriteLine(@"Created trigger SetNullOnBuildingDelete");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        
        private void DeleteAllTriggers(DbContext context) {
            var triggerNames = context.Database.SqlQuery<string>(
                "SELECT TRIGGER_NAME FROM INFORMATION_SCHEMA.TRIGGERS WHERE TRIGGER_SCHEMA = database()"
            ).ToList();

            foreach (var triggerName in triggerNames) {
                context.Database.ExecuteSqlCommand($"DROP TRIGGER IF EXISTS {triggerName}");
                Console.WriteLine(@"Dropped trigger " + triggerName);
            }
        }
    }
}
