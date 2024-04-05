using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Model
{
    [Table("responses")]
    public class Response
    {
        // Primary Key
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Des { get; set; }

        [DisplayFormat(DataFormatString = "dd/MM/yyyy HH:mm")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedAtFormatted => CreatedAt.ToString("dd/MM/yyyy HH:mm");
        // Foreign Key
        public int? RequestId { get; set; }
        [ForeignKey("RequestId")] public Request Request { get; set; }

        public Response() { }
        public Response(string des, int? requestId) 
        {
            Des = des;
            RequestId = requestId;
        }

    }
}
