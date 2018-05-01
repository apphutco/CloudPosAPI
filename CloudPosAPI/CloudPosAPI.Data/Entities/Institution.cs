using System;

namespace CloudPosAPI.Data.Entities
{
    public class Institution
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name {get; set; }
        public string Adress1 {get; set; }
        public string Adress2 {get; set; }
        public Guid CityId {get; set; }
        public Guid CountryID {get; set; }
        public Guid CurrencyId {get; set; }
        public string Language {get; set; }
        public string TimeZone {get; set; }
        public string ContractPerson {get; set; }
        public string Email {get; set; }
        public string TelephoneNO {get; set;}
        public byte[] Logo {get; set; }
        public int? IsActive {get; set; }        
    }
}
