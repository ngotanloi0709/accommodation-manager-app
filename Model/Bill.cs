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
        public int RentBill { get; set; }
        public int ElectricityBill { get; set; }
        public int WaterBill { get; set; }
        public int TotalBill { get; set; }
        [DisplayFormat(DataFormatString = "dd/MM/yyyy HH:mm")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedAtFormatted => CreatedAt.ToString("dd/MM/yyyy HH:mm");

        [EnumDataType(typeof(BillStatus))]
        public BillStatus Status { get; set; }
        public int? RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room Room { get; set; }
        
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public Bill() {}
        public Bill(int rentBill, int electricityBill, int waterBill, int? roomId)
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
        private int CalculateTotalBill()
        {
            return (this.RentBill + this.ElectricityBill + this.WaterBill);
        }
    }
    
    public enum BillStatus {
        Unpaid = 0,
        Pending = 1,
        Paid = 2
    }
}
