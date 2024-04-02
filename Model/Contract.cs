using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Model {
    [Table("contracts")]
    public class Contract {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")] public User User { get; set; }
        public int? RoomId { get; set; }
        [ForeignKey("RoomId")] public Room Room { get; set; }
        public int Price { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public bool IsTerminated { get; set; } = false;
        public List<Bill> Bills { get; set; }

        public Contract() { }

        public Contract(int userId, int roomId, int price, DateTime startDate, DateTime endDate, bool isTerminated) {
            UserId = userId;
            RoomId = roomId;
            Price = price;
            StartDate = startDate;
            EndDate = endDate;
            IsTerminated = isTerminated;
        }
    }
}
