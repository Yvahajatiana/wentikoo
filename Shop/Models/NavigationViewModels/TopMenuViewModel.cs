using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hashdji.Software.Shop.Models.NavigationViewModels
{
    public class TopMenuViewModel
    {
        public IList<MenuItem> MenuItems { get; set; }

        public Picture Logo { get; set; }
    }
}
