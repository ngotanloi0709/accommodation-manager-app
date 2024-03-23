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
        public bool IsDeleted { get; set; }
        public Double RentBill { get; set; }
        public Double ElectricityBill { get; set; }
        public Double WaterBill { get; set; }
        public Double TotalBill { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [EnumDataType(typeof(BillStatus))]
        public BillStatus Status { get; set; }

        public int? RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room Room { get; set; }
        
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public Bill() {}
        public Bill(Double rentBill, Double electricityBill, Double waterBill, int? roomId)
        {
            RentBill = rentBill;
            ElectricityBill = electricityBill;
            WaterBill = waterBill;
            TotalBill = CalculateTotalBill();
            RoomId = roomId;
            Status = BillStatus.Unpaid;
            IsDeleted = false;
        }

        public string toString() {             
            return "[Rent Bill: " + RentBill + " " + "Electricity Bill: " + ElectricityBill + " " + "Water Bill: " + WaterBill + " " + "Total Bill: " + TotalBill + " " + "Status: " + Status + "]";
        }
        private Double CalculateTotalBill()
        {
            return (this.RentBill + this.ElectricityBill + this.WaterBill);
        }
    }
}
