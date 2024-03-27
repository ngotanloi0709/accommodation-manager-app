using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Model
{
    [Table("users")]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        [EnumDataType(typeof(UserRole))] public UserRole Role { get; set; } = UserRole.Tenant;
        public bool IsFemale { get; set; }
        public DateTime DateOfBirth { get; set; } = new DateTime(1900, 1, 1);
        public string Phone { get; set; }
        public string IdentityNumber { get; set; }
        public byte[] Avatar { get; set; }
        public List<Contract> Contracts { get; set; }
        
        public User() { }
        
        public User(string email, string name, string password) {
            Email = email;
            Name = name;
            Password = password;
        }
        
        public User(string email, string name, string password, bool isFemale, string phone, string identityNumber, DateTime dateOfBirth) {
            Email = email;
            Name = name;
            Password = password;
            IsFemale = isFemale;
            Phone = phone;
            IdentityNumber = identityNumber;
            DateOfBirth = dateOfBirth;
        }
    }
    
    public enum UserRole {
        Tenant,
        Manager,
        Admin
    }
}
