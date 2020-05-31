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
        public Deposit(List<Product> products, Client client, DateTime? t = null, bool isTest = false)
        {
            Products = new List<Product>();
            Products.AddRange(products);
            Client = client;
            if (isTest == true)
            {
                Random rnd = new Random();
                DateTimeBuyOut = DateTime.Now.AddSeconds(rnd.Next(1, 30));
                DateTime = DateTime.Now;
            }
            else
            {
                if (t == null)
                    DateTime = DateTime.Now;
                else
                    DateTime = (DateTime)t;
                DateTimeBuyOut = DateTime.AddDays(60);
            }
            Price = 0;
            foreach (var pr in products)
                Price += pr.Price;
        }

        public List<Product> Products { set; get; }
        public Client Client { set; get; }
        public DateTime DateTime { set; get; }
        public DateTime DateTimeBuyOut { set; get; }
        public decimal Price { private set; get; }
        public string Name { get; set; }
    }
}
