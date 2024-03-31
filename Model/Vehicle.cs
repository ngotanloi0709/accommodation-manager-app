using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Model
{
    [Table("vehicles")]
    public class Vehicle
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public int Price { get; set; } = 100000;
        [EnumDataType(typeof(VehicleCategory))] public VehicleCategory Category { get; set; } = VehicleCategory.TwoWheel;
        public int? RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        
        public Vehicle() { }
        
        public Vehicle(string name, string number, int price, VehicleCategory category, int? roomId)
        {
            Name = name;
            Number = number;
            Price = price;
            Category = category;
            RoomId = roomId;
        }
    }
    
    public enum VehicleCategory
    {
        TwoWheel,
        FourWheel,
        ThreeWheel,
        Bicycle,
        ElectricBicycle
    }
}
