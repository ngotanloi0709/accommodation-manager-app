using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using AccommodationManagerApp.Migrations;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Repository {
    public abstract class Repository<T> where T : class {
        protected readonly DbContext Context;

        protected Repository(AccommodationManagerAppContext context) {
            Context = context;
        }

        public List<T> GetAll() {
            return Context.Set<T>().ToList();
        }

        public T GetById(int? id) {
            return Context.Set<T>().Find(id);
        }

        public void Add(T entity) {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }

        public void Update(int id, T entity) {
            var existingEntity = Context.Set<T>().Find(id);
            if (existingEntity != null) {
                // filter non-primary properties and non-set propertie
                foreach (var property in typeof(T).GetProperties())
                {
                    if (!property.GetCustomAttributes(typeof(KeyAttribute), false).Any() && property.CanWrite)
                    {
                        property.SetValue(existingEntity, property.GetValue(entity));
                    }
                }
                
                Context.SaveChanges();
            }
        }


        public void Delete(int id) {
            var entity = GetById(id);
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }
    }

    public class AccommodationManagerAppContext : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<InitLog> InitLogs { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<FixedPrice> FixedPrices { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Response> Responses { get; set; }

        public AccommodationManagerAppContext() : base("name=MySqlConnectionString") {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<AccommodationManagerAppContext, Configuration>());
        }
    }
}