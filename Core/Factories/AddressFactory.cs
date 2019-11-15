namespace Hashdji.Software.Core.Factories
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class AddressFactory
    {
        public static void Map(this Address inDb, Address updated)
        {
            inDb.City = updated.City;
            inDb.MoreExplanations = updated.MoreExplanations;
            inDb.Region = updated.Region;
            inDb.SectionName = updated.SectionName;
            inDb.Street = updated.Street;
            inDb.StreetNumber = updated.StreetNumber;
            inDb.Title = updated.Title;
        }
    }
}
