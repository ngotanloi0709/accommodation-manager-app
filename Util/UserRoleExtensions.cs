using System;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Util {
    public static class UserRoleExtensions {
        public static string ToVietnamese(this UserRole role)
        {
            switch (role)
            {
                case UserRole.Tenant:
                    return "Người thuê";
                case UserRole.Manager:
                    return "Người quản lý";
                case UserRole.Admin:
                    return "Quản trị viên";
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(role), role, null);
            }
        }
        
        public static UserRole ToUserRole(this string role)
        {
            switch (role)
            {
                case "Người thuê":
                    return UserRole.Tenant;
                case "Người quản lý":
                    return UserRole.Manager;
                case "Quản trị viên":
                    return UserRole.Admin;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(role), role, null);
            }
        }
    }
}