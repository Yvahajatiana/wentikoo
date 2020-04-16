using Hashdji.Software.Shop.Models.NavigationViewModels;
using Hashdji.Software.Shop.Models.ProductViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hashdji.Software.Shop.Components
{
    public class ProductSidebarViewComponent : ViewComponent
    {
        private readonly LinkGenerator linkGenerator;

        public ProductSidebarViewComponent(LinkGenerator linkGenerator)
        {
            this.linkGenerator = linkGenerator;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new ProductSidebarViewModel { Title = "Popular products", Products = new List<ProductViewModel>() };
            for (int i = 0; i < 3; i++)
            {
                model.Products.Add(new ProductViewModel
                {
                    Currency = "MGA",
                    Name = $"Product Number {i}",
                    OldPrice = 12 * i,
                    Picture = "images/product/4.jpg",
                    Price = 10 * i,
                    Url = linkGenerator.GetPathByAction("Details", "Product", new { id = $"product-number-{i}" })
                });
            }

            return View(model);
        }
    }
}
