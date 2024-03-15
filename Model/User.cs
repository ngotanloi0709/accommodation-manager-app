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
        [EnumDataType(typeof(UserRole))]
        public UserRole Role { get; set; }
        public bool IsFemale { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string IdentityNumber { get; set; }

        public User() { }
        
        public User(string email, string name, string password) {
            Email = email;
            Name = name;
            Password = password;
        }
    }
}
