using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudPosAPI.Data.Entities
{
    [Table("InstitutionPayment")]
    public class InstitutionPayment
    {
        [Key]
        public Guid id { get; set; }
        public Guid SubscriptionSchemeId { get; set; }
        public Guid PaymentMethodId { get; set; }
        public decimal PaymentAmount { get; set; }
        public string ReferenceId { get; set; }
        public DateTime PaymentDate { get; set; }
        public Guid PaymentBy { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }

        [ForeignKey("SubscriptionSchemeId")]
        public SubscriptionScheme SubscriptionScheme { get; set; }

        [ForeignKey("PaymentMethodId")]
        public PaymentMethod PaymentMethod { get; set; }

        [ForeignKey("PaymentBy")]
        public User User { get; set; }
    }
}
