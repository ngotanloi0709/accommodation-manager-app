using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AccommodationManagerApp.Repository;

namespace AccommodationManagerApp.Util {
    [Table("init_logs")]
    public class InitLog {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public InitLog(InitLogRepository initLogRepository) 
        {
            Console.WriteLine("Init Log created");
            Console.WriteLine("Program: " + CreatedAt);

            initLogRepository.Add(this);
        }
    }
}