using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Model {
    public enum UserRole {
        Tenant,
        Manager,
        Admin
    }
}