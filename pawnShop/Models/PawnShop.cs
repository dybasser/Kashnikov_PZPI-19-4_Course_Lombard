using pawnShop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pawnShop.Models
{
    [Serializable]
    public class PawnShop
    {
        public List<Deposit> Deposits { private set; get; }
        public List<Client> Clients { private set; get; }
        public List<Product> Products { private set; get; }
        public List<ForSale> ForSales { private set; get; }

        public PawnShop()
        {
            Deposits = new List<Deposit>();
            Clients = new List<Client>();
            Products = new List<Product>();
            ForSales = new List<ForSale>();
        }

        public void FillTestData(int n)
        {
            Random rnd = new Random();
            // Clients
            for (int i = 1; i <= n; ++i)
            {
                Clients.Add(new Client
                {
                    Name = $"Client{i}",
                    Password = "123",
                    Age = rnd.Next(18, 60),
                    Email = $"Client{i}@gmail.com"
                });
            }
            // Deposits
            for (int i = 0; i < n - 5; ++i)
            {
                var dep = new List<Product>();
                for (int j = 0; j < 5; ++j)
                {
                    var id = rnd.Next(1, 1000);
                    var weight = rnd.Next(1000, 5000);
                    Products.Add(new Product()
                    {
                        Id = id,
                        Name = $"Product{j}",
                        Price = i * 10,
                        Unit = "g",
                        Type = (j % 2 == 0) ? "gold" : "silver",
                        Weight = weight,
                        Sample = 999
                    });
                    dep.Add(new Product()
                    {
                        Id = id,
                        Name = $"Product{j}",
                        Price = i * 10,
                        Unit = "g",
                        Type = (j % 2 == 0) ? "gold" : "silver",
                        Weight = weight,
                        Sample = 999
                    });
                }
                Deposits.Add(new Deposit(dep, Clients[i], DateTime.Now + TimeSpan.FromDays(i)));
            }
            // ForSale
            foreach (var dep in Deposits)
            {
                if (dep.DateTime.Day % 2 == 0)
                    ForSales.Add(new ForSale(dep));
            }
        }

        public void Save()
        {
            new Dao(this).Save();
        }

        public void Load()
        {
            new Dao(this).Load();
        }
    }
}
