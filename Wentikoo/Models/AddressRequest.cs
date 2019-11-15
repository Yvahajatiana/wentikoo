namespace Hashdji.Software.Wentikoo.Models
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class AddressRequest
    {
        public string Title { get; set; }

        public string SectionName { get; set; }

        public string StreetNumber { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string MoreExplanations { get; set; }

        public Address ToEntity()
        {
            return new Address
            {
                City = City,
                MoreExplanations = MoreExplanations,
                Region = Region,
                SectionName = SectionName,
                Street = Street,
                StreetNumber = StreetNumber,
                Title = Title
            };
        }
    }
}
