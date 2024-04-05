using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Model
{
    [Table("requests")]
    public class Request
    {
        // Primary Key
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        // Common atributes
        public RequestStatus Status { get; set; } = RequestStatus.Unsolve;
        public string Des { get; set; }

        [DisplayFormat(DataFormatString = "dd/MM/yyyy HH:mm")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedAtFormatted => CreatedAt.ToString("dd/MM/yyyy HH:mm");
        // Foreign Key
        public int? UserId { get; set; }
        [ForeignKey("UserId")] public User User { get; set; }
        public Request() { }
        public Request(string description,int? userId)
        {
            Des = description;
            UserId = userId;
        }
    }
    public enum RequestStatus
    {
        Unsolve = 0,
        Solved = 1
    }
}
