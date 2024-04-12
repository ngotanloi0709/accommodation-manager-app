using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository {
    public class UserRepository : Repository<User> {
        public UserRepository(AccommodationManagerAppContext context) : base(context) { }

        public User GetByEmail(string email) {
            return Context.Set<User>().FirstOrDefault(u => u.Email == email);
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

        public User GetByName(string name) => Context.Set<User>().FirstOrDefault(user => user.Name == name);
        public List<User> GetAllByName(string name) {
            return Context.Set<User>().Where(u => u.Name.Contains(name) && u.Role == UserRole.Tenant).ToList();
        }

        public List<User> GetAllWithRoleNotTenantAndWithContractAndRoom() {
            return Context.Set<User>().Include("Contracts").Include("Room").Where(u => u.Role != UserRole.Tenant).ToList();
        }
    }
}