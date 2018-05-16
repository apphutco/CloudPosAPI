using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudPosAPI.Data.Entities
{
    [Table("Screen")]
    public class Screen
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }

        public virtual ICollection<ScreenEndpoint> ScreenEndpoints { get; set; }
        public virtual ICollection<ScreenAccess> ScreenAccesses { get; set; }
        public virtual ICollection<ScreenEndpointAccess> ScreenEndpointAccesses { get; set; }
        public virtual ICollection<Endpoint> Endpoints { get; set; }
    }
}
