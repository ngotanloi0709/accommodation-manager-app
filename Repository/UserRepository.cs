using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository {
    public class UserRepository : Repository<User> {
        public UserRepository(AccommodationManagerAppContext context) : base(context) { }

        public User GetByEmail(string email) {
            return Context.Set<User>().FirstOrDefault(u => u.Email == email);
        }

        public User GetById(int? id)
        {
            return Context.Set<User>().FirstOrDefault(u => u.Id == id);
        }

        public User GetByNameAndEmail(string name, string email) {
            return Context.Set<User>().FirstOrDefault(u => u.Name == name && u.Email == email && u.Role == UserRole.Tenant);
        }

        public List<User> GetAllWithRoleTenantAndWithContractAndRoom() {
            return Context.Set<User>().Include("Contracts").Include("Room").Where(u => u.Role == UserRole.Tenant).ToList();
        }

        public List<User> GetAllWithRoleTenant() {
            return Context.Set<User>().Where(u => u.Role == UserRole.Tenant).ToList();
        }

        public List<User> GetAllByName(string name) {
            return Context.Set<User>().Where(u => u.Name.Contains(name) && u.Role == UserRole.Tenant).ToList();
        }
    }
}