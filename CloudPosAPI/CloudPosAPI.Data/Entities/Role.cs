using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudPosAPI.Data.Entities
{
    public class Role
    {
        public Guid Id { get; set; }
        public Guid InstitutionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive  { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
