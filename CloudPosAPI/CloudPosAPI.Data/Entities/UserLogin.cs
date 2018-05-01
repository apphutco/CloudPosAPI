using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudPosAPI.Data.Entities
{
    public class UserLogin
    {
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
    }
}
