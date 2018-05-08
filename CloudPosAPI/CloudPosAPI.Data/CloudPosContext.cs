using CloudPosAPI.Data.Entities;
using System.Data.Entity;

namespace CloudPosAPI.Data
{
    public class CloudPosContext : DbContext
    {
        public CloudPosContext() : base("name=CloudPosDBConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CloudPosContext, Migrations.Configuration>());
            
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Endpoint> Endpoints { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<HttpLog> HttpLogs { get; set; }
        public DbSet<InstitutionPayment> InstitutionPayments { get; set; }
        public DbSet<InstitutionSubsctiption> InstitutionSubsctiptions { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<ScreenAccess> ScreenAccesses { get; set; }
        public DbSet<ScreenEndpoint> ScreenEndpoints { get; set; }
        public DbSet<ScreenEndpointAccess> ScreenEndpointAccesses { get; set; }
        public DbSet<SubscriptionScheme> SubscriptionSchemes { get; set; }
        public DbSet<SubscriptionType> SubscriptionTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Institution>().HasMany(t => t.Users).WithRequired(a => a.Institution).WillCascadeOnDelete(false);
            modelBuilder.Entity<Role>().HasMany(t => t.Users).WithRequired(a => a.Role).WillCascadeOnDelete(false);
            modelBuilder.Entity<Currency>().HasMany(t => t.Institutions).WithRequired(a => a.Currency).WillCascadeOnDelete(false);

        }

    }
}
