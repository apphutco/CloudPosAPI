using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudPosAPI.Data.Entities
{
    [Table("Endpoint")]
    public class Endpoint
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ScreenId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<ScreenEndpoint> ScreenEndpoints { get; set; }
    }
}
