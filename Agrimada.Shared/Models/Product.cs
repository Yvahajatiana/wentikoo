using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agrimada.Shared.Models
{
    public class Product : EntityBase
    {
        public string Name { get; set; }

        public int CategoryId { get; set; }
        
        public virtual Category Category { get; set; }

        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}
