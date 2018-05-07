using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudPosAPI.Data.Entities
{
    [Table("ScreenEndpoint")]
    public class ScreenEndpoint
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ScreenId { get; set; }
        public Guid EndpointId { get; set; }

        [ForeignKey("ScreenId")]
        public Screen Screen { get; set; }

        [ForeignKey("EndpointId")]
        public Endpoint Endpoint { get; set; }

        public virtual ICollection<ScreenEndpointAccess> ScreenEndpointAccesses { get; set; }
    }
}
