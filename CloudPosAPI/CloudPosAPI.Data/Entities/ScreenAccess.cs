using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudPosAPI.Data.Entities
{
    [Table("ScreenAccess")]
    public class ScreenAccess
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ScreenId { get; set; }
        public Guid RoleId { get; set; }
        public bool IsFullyAccessible { get; set; }
        public Guid GrantedBy { get; set; }
        public DateTime GrantedDateTime { get; set; }

        [ForeignKey("ScreenId")]
        public Screen Screen {get; set;}

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        [ForeignKey("GrantedBy")]
        public User User { get; set; }
    }
}
