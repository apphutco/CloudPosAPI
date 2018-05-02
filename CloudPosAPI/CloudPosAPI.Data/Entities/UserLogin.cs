using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudPosAPI.Data.Entities
{
    [Table("UserLogin")]
    public class UserLogin
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid InstitutionId { get; set; }
        public DateTime GrantedTime { get; set; }
        public string DeviceType { get; set; }
        public string DeviceId { get; set; }
        public string LoginType { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public bool IsValid { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("InstitutionId")]
        public Institution Institution { get; set; }
    }
}
