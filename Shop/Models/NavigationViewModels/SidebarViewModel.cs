using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hashdji.Software.Shop.Models.NavigationViewModels
{
    public class SidebarViewModel
    {
        public string MenuTitle { get; set; }

        public Picture Picture { get; set; }

        public IList<MenuItem> MenuItems { get; set; }
    }
}
