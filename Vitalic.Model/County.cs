using System;

namespace Vitalic.Model
{
    public class County
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid CountryId { get; set; }
    }
}
