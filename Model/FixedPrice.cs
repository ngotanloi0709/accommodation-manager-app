using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Model {
    [Table("fixed_prices")]
    public class FixedPrice {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public FixedPriceType Type { get; set; }
        public int Price { get; set; }
    }
    
    public enum FixedPriceType {
        Water,
        Electricity,
        Internet
    }
}