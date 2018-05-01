using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudPosAPI.Data.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Guid InstitutionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string TelephoneNo { get; set; }
        public byte[] ProfilePic { get; set; }
        public bool IsActive { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PinCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
