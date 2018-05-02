using CloudPosAPI.Data.Entities;
using System;
using System.Data.Entity.Migrations;

namespace CloudPosAPI.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CloudPosContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            
        }

        protected override void Seed(CloudPosContext context)
        {
            context.Institutions.AddOrUpdate(
                    new Institution()
                    {
                        Address1 = "Address1",
                        Address2 = "Address2",
                        CityId = Guid.NewGuid(),
                        Code = "TEST",
                        ContractPerson = "Jhon Doe",
                        CountryId = Guid.NewGuid(),
                        CurrencyId = Guid.NewGuid(),
                        Email = "johndoe@example.com",
                        Id = Guid.Parse("a4abca44-f06c-453b-8c1c-5833848ed21b"),
                        IsActive = true,
                        Language = "EN",
                        Logo = null,
                        Name = "Test Institution",
                        TelephoneNo = "000000000",
                        TimeZone = "+530"
                    }
                );


        }
    }
}
