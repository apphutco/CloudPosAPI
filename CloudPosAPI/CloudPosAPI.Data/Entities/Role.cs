using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudPosAPI.Data.Entities
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        public Guid InstitutionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive  { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }

        public ICollection<User> Users { get; set; }

        [ForeignKey("InstitutionId")]
        public Institution Institution { get; set; }
    }
}
