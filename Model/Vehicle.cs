using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Model
{
    [Table("vehicles")]
    public class Vehicle
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [EnumDataType(typeof(VehicleCategory))] public VehicleCategory Category { get; set; } = VehicleCategory.two_wheel;
        public string name { get; set; }
        public string number { get; set; }
        public int? RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        
        public Vehicle() { }
        public Vehicle(string name, string number, int? RoomId, VehicleCategory category)
        {
            this.name = name;
            this.number = number;
            this.RoomId = RoomId;
            this.Category = category;
        }

        public Vehicle(string name, string number, int? RoomId)
        {
            this.name = name;
            this.number = number;
            this.RoomId = RoomId;
        }
    }
}
