using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hashdji.Software.Shop.Models.ProductViewModels
{
    public class ProductDetailsViewModel
    {
        public string Name { get; set; }

        public string SubTitle { get; set; }

        public IEnumerable<string> Specifications { get; set; }

        public decimal Price { get; set; }

        public decimal OldPrice { get; set; }

        public string Currency { get; set; }

        public IEnumerable<Picture> Pictures { get; set; }

        public IEnumerable<Picture> Sliders { get; set; }

        public IEnumerable<ProductViewModel> RelatedProducts { get; set; }

        public Dictionary<string, string> Desciptions { get; set; }
    }

}
