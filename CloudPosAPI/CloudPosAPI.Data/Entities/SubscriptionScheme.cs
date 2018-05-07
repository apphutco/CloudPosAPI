using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudPosAPI.Data.Entities
{
    [Table("SubscriptionScheme")]
    public class SubscriptionScheme
    {
        [Key]
        public Guid Id { get; set; }
        public Guid SubscriptionTypeId { get; set; }
        public string Name { get; set; }
        public decimal UnitPriceUsd { get; set; }

        [ForeignKey("SubscriptionTypeId")]
        public SubscriptionType SubscriptionType { get; set; }

        public virtual ICollection<InstitutionSubsctiption> InstitutionSubsctiptions { get; set; }
        public virtual ICollection<InstitutionPayment> InstitutionPayments { get; set; }
    }
}
