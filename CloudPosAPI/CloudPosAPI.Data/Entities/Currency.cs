using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudPosAPI.Data.Entities
{
    public class Currency
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
