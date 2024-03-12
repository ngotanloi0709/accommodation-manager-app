using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Model {
    [Table("rooms")]
    public class Room {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public int? BuildingId { get; set; }
        [ForeignKey("BuildingId")]
        public Building Building { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        [EnumDataType(typeof(RoomStatus))]
        public RoomStatus Status { get; set; } = RoomStatus.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Room() 
        {
        }
        
        public Room(string roomNumber, Building building, User user, RoomStatus status) {
            RoomNumber = roomNumber;
            Building = building;
            User = user;
            Status = status;
        }
    }
}