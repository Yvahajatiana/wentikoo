using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hashdji.Software.Shop.Models;
using Hashdji.Software.Shop.Models.ProductViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        private readonly LinkGenerator linkGenerator;

        public ProductController(LinkGenerator linkGenerator)
        {
            this.linkGenerator = linkGenerator;
        }

        public IActionResult Index([FromQuery] int page = 1)
        {
            if(page < 1)
            {
                page = 1;
            }

            var products = new List<ProductViewModel>();
            for(int i = 0; i < 1200; i++)
            {
                products.Add(new ProductViewModel
                {
                    Currency = "MGA",
                    Name = $"Product Number {i}",
                    OldPrice = 12 * i,
                    Picture = "images/product/4.jpg",
                    Price = 10 * i,
                    Url = linkGenerator.GetPathByAction("Details", "Product", new { id = $"product-number-{i}" })
                });
            }
            var size = 12;
            var model = new ProductListViewModel
            {
                PageCount = products.Count / size,
                Page = page,
                Route = linkGenerator.GetPathByAction("Index", "Product"),
                Products = Paginate(products, page, size)
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Details([FromRoute] string slug)
        {
            var specifications = new List<string>
            {
                "Food from Farm Hong Quat Packging",
                "100% Organic Food",
                "100% Fresh Not Chemicals"
            };

            var relatedProducts = new List<ProductViewModel>();
            var photos = new List<Picture>();
            var sliders = new List<Picture>();
            var descriptions = new Dictionary<string, string>();

            var description = " Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis.";

            descriptions.Add("Details", description);
            descriptions.Add("Payment", description);
            descriptions.Add("Delivery", description);

            for (int i = 0; i < 3; i++)
            {
                relatedProducts.Add(new ProductViewModel
                {
                    Currency = "MGA",
                    Name = $"Product Number {i}",
                    OldPrice = 12 * i,
                    Picture = "/images/product/1.jpg",
                    Price = 10 * i,
                    PictureAlt = "",
                    Url = linkGenerator.GetPathByAction("Details", "Product", new { id = $"product-number-{i}" })
                });

                photos.Add(new Picture
                {
                    Alt = $"list{i}",
                    Url = "/images/product/list1.png"
                });

                sliders.Add(new Picture
                {
                    Alt = $"slider{i}",
                    Url = "/images/product/slider1.jpg"
                });
            }

            var model = new ProductDetailsViewModel
            {
                Currency = "MGA",
                Name = $"Product Number: {slug}",
                OldPrice = 12,
                Price = 10,
                SubTitle = "100% Organic Food from Farm Tomoko",
                Specifications = specifications,
                RelatedProducts = relatedProducts,
                Desciptions = descriptions,
                Pictures = photos,
                Sliders = sliders
            };

            return View(model);
        }

        private IEnumerable<ProductViewModel> Paginate(IEnumerable<ProductViewModel> data, int page, int size)
        {
            return data.Skip((page - 1) * size).Take(size);
        }
    }
}