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
            CreateRoomDeleteTrigger(context);
            CreateUserDeleteTrigger(context);

            if (!context.Users.Any()) {
                context.Users.AddOrUpdate(new User("ngotanloi0709@gmail.com", "Judian Ngo",
                    PasswordHelper.HashPassword("123"), UserRole.Admin));
                context.Users.AddOrUpdate(new User("admin@gmail.com", "Admin", PasswordHelper.HashPassword("123"), UserRole.Admin));
                context.Users.AddOrUpdate(new User("user1@gmail.com", "User 1", PasswordHelper.HashPassword("123"), UserRole.Tenant));
                context.Users.AddOrUpdate(new User("user2@gmail.com", "User 2", PasswordHelper.HashPassword("123"), UserRole.Tenant));
                context.Users.AddOrUpdate(new User("user3@gmail.com", "User 3", PasswordHelper.HashPassword("123"), UserRole.Tenant));
                context.Users.AddOrUpdate(new User("user4@gmail.com", "User 4", PasswordHelper.HashPassword("123"), UserRole.Tenant));
            }

            if (!context.Buildings.Any()) {
                context.Buildings.AddOrUpdate(new Building { Name = "Building 1" });
                context.Buildings.AddOrUpdate(new Building { Name = "Building 2" });
                context.Buildings.AddOrUpdate(new Building { Name = "Building 3" });
            }
            
            if (!context.Rooms.Any()) {
                context.Rooms.AddOrUpdate(new Room { RoomNumber = "101", BuildingId = null });
                context.Rooms.AddOrUpdate(new Room { RoomNumber = "102", BuildingId = null });
                context.Rooms.AddOrUpdate(new Room { RoomNumber = "103", BuildingId = null });
                context.Rooms.AddOrUpdate(new Room { RoomNumber = "201", BuildingId = null });
                context.Rooms.AddOrUpdate(new Room { RoomNumber = "202", BuildingId = null });
                context.Rooms.AddOrUpdate(new Room { RoomNumber = "203", BuildingId = null });
                context.Rooms.AddOrUpdate(new Room { RoomNumber = "301", BuildingId = null });
                context.Rooms.AddOrUpdate(new Room { RoomNumber = "302", BuildingId = null });
                context.Rooms.AddOrUpdate(new Room { RoomNumber = "303", BuildingId = null });
            }

            if (!context.Bills.Any()) {
                context.Bills.AddOrUpdate(new Bill(1000000, 887000, 206000, null));
                context.Bills.AddOrUpdate(new Bill(1500000, 621000, 372000, null));
                context.Bills.AddOrUpdate(new Bill(2000000, 913000, 455000, null));
            }

            if (!context.Vehicles.Any()) {
                context.Vehicles.AddOrUpdate(new Vehicle { name = "Honda", number = "63D-0301", RoomId = null });
                context.Vehicles.AddOrUpdate(new Vehicle { name = "Yamaha", number = "86F-31235", RoomId = null });
                context.Vehicles.AddOrUpdate(new Vehicle { name = "Suzuki", number = "59F-5234", RoomId = null });
            }
        }

        private void CreateBuildingDeleteTrigger(DbContext context) {
            try {
                string createTriggerSql = @"
                    CREATE TRIGGER SetNullOnBuildingDelete
                    BEFORE DELETE ON buildings
                    FOR EACH ROW
                    BEGIN
                        UPDATE rooms SET BuildingId = NULL WHERE BuildingId = OLD.Id;
                    END;
                    ";
                context.Database.ExecuteSqlCommand(createTriggerSql);
                Console.WriteLine(@"Created trigger SetNullOnBuildingDelete");
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        private void CreateRoomDeleteTrigger(DbContext context) {
            try {
                string createTriggerSql = @"
                    CREATE TRIGGER SetNullOnRoomDelete
                    BEFORE DELETE ON rooms
                    FOR EACH ROW
                    BEGIN
                        UPDATE vehicles SET RoomId = NULL WHERE RoomId = OLD.Id;
                        UPDATE contracts SET RoomId = NULL WHERE RoomId = OLD.Id;
                        UPDATE bills SET RoomId = NULL WHERE RoomId = OLD.Id;
                    END;
                    ";
                context.Database.ExecuteSqlCommand(createTriggerSql);
                Console.WriteLine(@"Created trigger SetNullOnRoomDelete");
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        private void CreateUserDeleteTrigger(DbContext context) {
            try {
                string createTriggerSql = @"
                    CREATE TRIGGER SetNullOnUserDelete
                    BEFORE DELETE ON users
                    FOR EACH ROW
                    BEGIN
                        UPDATE contracts SET UserId = NULL WHERE UserId = OLD.Id;
                        UPDATE bills SET UserId = NULL WHERE UserId = OLD.Id;
                    END;
                    ";
                context.Database.ExecuteSqlCommand(createTriggerSql);
                Console.WriteLine(@"Created trigger SetNullOnUserDelete");
            }
            catch (Exception e) {
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