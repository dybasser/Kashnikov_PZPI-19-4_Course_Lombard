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
            Products = products;
            Client = client;
            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
            DateTimeBuyOut = DateTime.AddSeconds(10);
        }

        public List<Product> Products { private set; get; }
        public Client Client { private set; get; }
        public DateTime DateTime { private set; get; }
        public DateTime DateTimeBuyOut { private set; get; }
    }
}
