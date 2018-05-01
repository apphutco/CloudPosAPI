using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudPosAPI.Data.Entities
{
    public class Endpoint
    {
        public Guid Id { get; set; }
        public Guid ScreenId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
}
}
