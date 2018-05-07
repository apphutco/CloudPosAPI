using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudPosAPI.Data.Entities
{
    [Table("InstitutionSubsctiption")]
    public class InstitutionSubsctiption
    {
        [Key]
        public Guid id { get; set; }
        public Guid SubscriptionSchemeId { get; set; }
        public Guid InstitutionId { get; set; }
        public string SubscriptionTypeCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Int64 AllowedTransactions { get; set; }
        public Int64 CurrentTransactions { get; set; }
        public decimal GrossCost { get; set; }
        public Decimal NettCost { get; set; }
        public bool IsDiscounted { get; set; }
        public decimal DiscountRate { get; set; }
        public bool IsActive { get; set; }
        public bool IsRenewed { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime RenewedDate { get; set; }
        public Guid RenewedBy { get; set; }

        [ForeignKey("SubscriptionSchemeId")]
        public SubscriptionScheme SubscriptionScheme { get; set; }

        [ForeignKey("InstitutionId")]
        public Institution Institution { get; set; }

        [ForeignKey("CreatedBy")]
        public User User { get; set; }

        [ForeignKey("RenewedBy")]
        public User User1 { get; set; }
    }
}
