using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudPosAPI.Data.Entities
{
    [Table("SubscriptionType")]
    public class SubscriptionType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<SubscriptionScheme> SubscriptionSchemes { get; set; }
    }
}
