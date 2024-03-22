using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Model
{
    [Table("vehicles")]
    public class Vehicle
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public int? RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string type, string name, string number, int? RoomId)
        {
            this.type = type;
            this.name = name;
            this.number = number;
            this.RoomId = RoomId;
        }
    }
}
