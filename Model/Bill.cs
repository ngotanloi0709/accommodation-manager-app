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
        public int ElecQuantity { get; set; }
        public int WaterQuantity { get; set; }
        public int ElecFee { get; set; } = 0;
        public int WaterFee { get; set; } = 0;
        public int InternetFee { get; set; } = 0;
        [EnumDataType(typeof(BillStatus))]
        public BillStatus Status { get; set; } = BillStatus.Unpaid;
        public int? ContractId { get; set; }
        [ForeignKey("ContractId")] public Contract Contract { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")] public User User { get; set; }
        // Date
        [DisplayFormat(DataFormatString = "dd/MM/yyyy HH:mm")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedAtFormatted => CreatedAt.ToString("dd/MM/yyyy");

        public Bill() { }

        public Bill(int elecQuantity, int waterQuantity, int? contractId)
        {
            ElecQuantity = elecQuantity;
            WaterQuantity = waterQuantity;
            ContractId = contractId;
        }
    }
    
public enum BillStatus
    {
        Unpaid,
        Paid
    }
}
