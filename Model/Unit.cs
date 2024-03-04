using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Models {
    [Table("units")]
    public class Unit {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Building { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}