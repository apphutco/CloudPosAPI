using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudPosAPI.Data.Entities
{
    [Table("PaymentMethod")]
    public class PaymentMethod
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<InstitutionPayment> InstitutionPayments { get; set; }
    }
}
