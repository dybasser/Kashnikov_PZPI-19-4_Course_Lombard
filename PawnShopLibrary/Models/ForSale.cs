using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pawnShop.Models
{
    [Serializable]
    public class ForSale
    {
        public ForSale(Deposit dep)
        {
            var pr = new List<Product>();
            pr.AddRange(dep.Products);
            Products = pr;
        }

        public List<Product> Products { get; private set; }
    }
}
