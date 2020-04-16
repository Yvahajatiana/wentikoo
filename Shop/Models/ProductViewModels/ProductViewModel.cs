namespace Hashdji.Software.Shop.Models.ProductViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ProductViewModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal OldPrice { get; set; }

        public string Picture { get; set; }

        public string PictureAlt { get; set; }

        public string Currency { get; set; }

        public string Url { get; set; }
    }
}
