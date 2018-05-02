using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudPosAPI.Data.Entities
{
    [Table("HttpLog")]
    public class HttpLog
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid InstitutionId { get; set; }
        public Guid CorrelationId { get; set; }
        public DateTime DateTime { get; set; }
        public string Url { get; set; }
        public string Headers { get; set; }
        public string Payload { get; set; }
        public string Type { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("InstitutionId")]
        public Institution Institution { get; set; }
    }
}
