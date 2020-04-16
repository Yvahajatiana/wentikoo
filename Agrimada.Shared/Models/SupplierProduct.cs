using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agrimada.Shared.Models
{
    public class SupplierProduct : EntityBase
    {
        public int SupplierId { get; set; }

        public  int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

    }
}
