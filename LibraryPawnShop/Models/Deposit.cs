using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPawnShop.Models
{
    [Serializable]
    public class Deposit
    {
        public Deposit(List<Product> products, Client client, DateTime? t = null)
        {
            Products = new List<Product>();
            Products.AddRange(products);
            Client = client;
            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
            DateTimeBuyOut = DateTime.AddSeconds(10);
            Price = 0;
            foreach (var pr in products)
                Price += pr.Price;
        }

        public Deposit()
        {

        }

        public List<Product> Products { set; get; }
        public Client Client { set; get; }
        public DateTime DateTime { set; get; }
        public DateTime DateTimeBuyOut { set; get; }
        public decimal Price { private set; get; }
        public string Name { get; set; }
    }
}
