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
                context.Users.AddOrUpdate(new User("ql7769663@gmail.com", "Eric Le",
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
            
            if (!context.Vehicles.Any()) {
                context.Vehicles.AddOrUpdate(new Vehicle { Name = "Honda", Number = "63D-0301", RoomId = null });
                context.Vehicles.AddOrUpdate(new Vehicle { Name = "Yamaha", Number = "86F-31235", RoomId = null });
                context.Vehicles.AddOrUpdate(new Vehicle { Name = "Suzuki", Number = "59F-5234", RoomId = null });
            }
            
            if(!context.Contracts.Any())
            {
                context.Contracts.AddOrUpdate(new Contract(1500000));
                context.Contracts.AddOrUpdate(new Contract(1000000));
                context.Contracts.AddOrUpdate(new Contract(2000000));
            }

            if (!context.Bills.Any())
            {
                context.Bills.AddOrUpdate(new Bill(100, 15, 10000, 5000, 20000, 100000, 500000));
                context.Bills.AddOrUpdate(new Bill(150, 18, 15000, 8000, 25000, 120000, 600000));
                context.Bills.AddOrUpdate(new Bill(120, 16, 12000, 6000, 22000, 110000, 550000));
                context.Bills.AddOrUpdate(new Bill(200, 20, 20000, 10000, 30000, 150000, 750000));
                context.Bills.AddOrUpdate(new Bill(180, 17, 18000, 9000, 28000, 140000, 700000));
                context.Bills.AddOrUpdate(new Bill(250, 22, 25000, 12000, 35000, 180000, 900000));
                context.Bills.AddOrUpdate(new Bill(300, 25, 30000, 15000, 40000, 200000, 1000000));
                context.Bills.AddOrUpdate(new Bill(350, 28, 35000, 16000, 45000, 220000, 1100000));
                context.Bills.AddOrUpdate(new Bill(400, 30, 40000, 18000, 50000, 250000, 1250000));
            }
            
            if (!context.Requests.Any())
            {
                context.Requests.AddOrUpdate(new Request("Cúp điện kìa", null));
                context.Requests.AddOrUpdate(new Request("Tiền nhà gì đóng hoài vậy", null));
                context.Requests.AddOrUpdate(new Request("Không được chửi thề", null));
            }

            if (!context.FixedPrices.Any())
            {
                context.FixedPrices.AddOrUpdate(new FixedPrice { Type = FixedPriceType.Water, Price = 10000 });
                context.FixedPrices.AddOrUpdate(new FixedPrice { Type = FixedPriceType.Electricity, Price = 7500 });
                context.FixedPrices.AddOrUpdate(new FixedPrice { Type = FixedPriceType.Internet, Price = 100000 });
            }
        }

        private void CreateBuildingDeleteTrigger(DbContext context) {
            try {
                var createTriggerSql = @"
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
                var createTriggerSql = @"
                    CREATE TRIGGER SetNullOnRoomDelete
                    BEFORE DELETE ON rooms
                    FOR EACH ROW
                    BEGIN
                        UPDATE vehicles SET RoomId = NULL WHERE RoomId = OLD.Id;
                        UPDATE contracts SET RoomId = NULL WHERE RoomId = OLD.Id;
                        UPDATE bills SET RoomId = NULL WHERE RoomId = OLD.Id;
                        UPDATE users SET RoomId = NULL WHERE RoomId = OLD.Id;
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
                var createTriggerSql = @"
                    CREATE TRIGGER SetNullOnUserDelete
                    BEFORE DELETE ON users
                    FOR EACH ROW
                    BEGIN
                        UPDATE contracts SET UserId = NULL WHERE UserId = OLD.Id;
                        UPDATE bills SET UserId = NULL WHERE UserId = OLD.Id;
                        UPDATE requests SET UserId = NULL WHERE UserId = OLD.Id;
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