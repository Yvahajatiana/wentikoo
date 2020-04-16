namespace Hashdji.Software.Shop.Models.ProductViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ProductListViewModel : PaginedViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
