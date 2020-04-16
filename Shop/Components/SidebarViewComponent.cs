using Hashdji.Software.Shop.Models.NavigationViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hashdji.Software.Shop.Components
{
    public class SidebarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new SidebarViewModel 
            { 
                MenuItems = new List<MenuItem>(),
                MenuTitle = "Categories",
                Picture = new Models.Picture
                {
                    Url = "~/images/blog/widget2.jpg",
                    Alt = "Alt picture"
                }
            };

            model.MenuItems.Add(new MenuItem { Title = "All Post", Url = "/" });
            model.MenuItems.Add(new MenuItem { Title = "Vegetables", Url = "/product" });
            model.MenuItems.Add(new MenuItem { Title = "Fruits", Url = "/" });
            model.MenuItems.Add(new MenuItem { Title = "Dried", Url = "/" });
            model.MenuItems.Add(new MenuItem { Title = "Vegetables", Url = "/" });
            model.MenuItems.Add(new MenuItem { Title = "Dried Fruit", Url = "/"  });

            return View(model);
        }
    }
}
