using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hashdji.Software.Shop.Models.NavigationViewModels
{
    public class MenuItem
    {
        public string Url { get; set; }

        public string Title { get; set; }

        public string Position { get; set; }

        public IList<MenuItem> Children { get; set; }
    }
}
