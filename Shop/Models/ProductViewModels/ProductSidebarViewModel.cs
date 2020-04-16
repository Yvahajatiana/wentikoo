using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hashdji.Software.Shop.Models.ProductViewModels
{
    public class ProductSidebarViewModel
    {
        public IList<ProductViewModel> Products { get; set; }

        public string Title { get; set; }
    }
}
