using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Model {
    [Table("contracts")]
    public class Contract
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")] public User User { get; set; }
        public int? RoomId { get; set; }
        [ForeignKey("RoomId")] public Room Room { get; set; }
        public int Price { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddMonths(3); // Set EndDate to StartDate + 3 months
        public bool IsTerminated { get; set; } = false;
        public List<Bill> Bills { get; set; }

        public Contract() { }

        // Constructor use for Testing in Migration
        public Contract(int price)
        {
            Price = price;
            EndDate = StartDate.AddMonths(3);
        }
    }
}
