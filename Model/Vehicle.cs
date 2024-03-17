using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AccommodationManagerApp.Model
{
    [Table("vehicles")]
    public class Vehicle
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string number { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string type, string name, string number)
        {
            this.type = type;
            this.name = name;
            this.number = number;
        }
    }
}
