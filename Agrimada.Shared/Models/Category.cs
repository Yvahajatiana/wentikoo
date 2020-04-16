using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agrimada.Shared.Models
{
    public class Category : EntityBase
    {
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
