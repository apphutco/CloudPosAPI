using CloudPosAPI.Data.Entities;
using System.Data.Entity;

namespace CloudPosAPI.Data
{
    public class CloudPosContext : DbContext
    {
        public CloudPosContext() : base("name=CloudPosDBConnectionString")
        {

        }


        public DbSet<Institution> Institutions { get; set; }
    }
}
