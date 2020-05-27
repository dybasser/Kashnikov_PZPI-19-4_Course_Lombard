using LibraryPawnShop.DAL;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace LibraryPawnShop.Models
{
    [Serializable]
    public class PawnShop
    {
        public List<Deposit> Deposits { private set; get; }
        public List<Client> Clients { private set; get; }
        public List<Product> Products { private set; get; }
        public List<Product> ForSale { private set; get; }

        public PawnShop()
        {
            Deposits = new List<Deposit>();
            Clients = new List<Client>();
            Products = new List<Product>();
            ForSale = new List<Product>();
        }

        public void FillTestData(int n)
        {
            for (int i = 0; i < n; ++i)
            {
                var noImage = new Bitmap(Path.GetFullPath("image.png"));
                var rnd = new Random();
                var dep = new List<Product>();
                for (int j = 0; j < 3; ++j)
                {
                    var id = rnd.Next(1, 1000);
                    var weight = rnd.Next(1000, 5000);
                    Product A = new Product()
                    {
                        Id = id,
                        Name = $"Product{j}",
                        Price = i * 10,
                        Unit = "g",
                        Type = (j % 2 == 0) ? "gold" : "silver",
                        Weight = weight,
                        Sample = 999,
                        Image = noImage
                    };
                    Products.Add(A);
                    dep.Add(A);
                }
                Client B = new Client()
                {
                    Id = rnd.Next(10, 100),
                    Name = $"Client{i}",
                    Password = "123",
                    Age = rnd.Next(18, 60),
                    Email = $"Client{i}@gmail.com"
                };
                Clients.Add(B);
                Deposits.Add(new Deposit(dep, B, DateTime.Now + TimeSpan.FromDays(i)));
                Deposits[i].Name = $"Deposit{i}";
            }
        }

        public void DateCheck()
        {
            for (int i = 0; i < Deposits.Count; ++i)
            {
                if (DateTime.Now >= Deposits[i].DateTimeBuyOut)
                {
                    ForSale.AddRange(Deposits[i].Products);
                    Deposits.RemoveAt(i);
                }
            }
        }

        public int IndOfDepByName(string name)
        {
            for (int i = 0; i < Deposits.Count; ++i)
            {
                if (Deposits[i].Name == name)
                {
                    return i;
                }
            }
            return -1;
        }

        public List<Deposit> FindDepositsByClient(Client client)
        {
            var deposits = new List<Deposit>();
            foreach (var dep in Deposits)
            {
                if (dep.Client == client) deposits.Add(dep);
            }
            return deposits;
        }

        public void ForSaleDelete(string name)
        {
            for (int i = 0; i < ForSale.Count; ++i)
            {
                if (ForSale[i].Name == name)
                {
                    ForSale.RemoveAt(i);
                    break;
                }
            }
        }

        public Client SearchClient(string name)
        {
            foreach (var cl in Clients)
            {
                if (cl.Name == name) return cl;
            }
            return null;
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
