using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Models {
    [Table("rooms")]
    public class Room {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public int BuildingId { get; set; }
        [ForeignKey("BuildingId")]
        public Building Building { get; set; }
        public RoomStatus Status { get; set; } = RoomStatus.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}