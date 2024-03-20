using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Model
{
    [Table("bills")]
    public class Bill
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Double RentBill { get; set; }
        public Double ElectricityBill { get; set; }
        public Double WaterBill { get; set; }
        public Double TotalBill { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [EnumDataType(typeof(BillStatus))]
        public BillStatus Status { get; set; } = BillStatus.Unpaid;

        public int? RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        public Bill() {}
        public Bill(Double rentBill, Double electricityBill, Double waterBill, Double totalBill, int? roomId, BillStatus status)
        {
            RentBill = rentBill;
            ElectricityBill = electricityBill;
            WaterBill = waterBill;
            TotalBill = totalBill;
            RoomId = roomId;
            Status = status;
        }
    }
}
