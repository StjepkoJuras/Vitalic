using System;

namespace Vitalic.Model
{
    public class City
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid CountryId { get; set; }
        public Guid CountyId { get; set; }
    }
}
