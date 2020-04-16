using Hashdji.Software.Shop.Models.NavigationViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hashdji.Software.Shop.Components
{
    public class TopMenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new TopMenuViewModel
            {
                Logo = new Models.Picture
                {
                    Alt = "Logo",
                    Url = "~/images/logo.png"
                },
                MenuItems = new List<MenuItem>()
            };

            model.MenuItems.Add(new MenuItem { Title = "Home", Url = "/", Position = "left" });
            model.MenuItems.Add(new MenuItem { Title = "Product", Url = "/product", Position = "left" });
            model.MenuItems.Add(new MenuItem { Title = "Store", Url = "/", Position = "left" });
            model.MenuItems.Add(new MenuItem { Title = "Store", Url = "/", Position = "right" });
            model.MenuItems.Add(new MenuItem { Title = "Store", Url = "/", Position = "right" });
            model.MenuItems.Add(new MenuItem { Title = "Store", Url = "/", Position = "right" });

            return View(model);
        }
    }
}
