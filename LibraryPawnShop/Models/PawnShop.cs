using LibraryPawnShop.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace LibraryPawnShop.Models
{
    [Serializable]
    public class PawnShop
    {
        const int RANKUP = 10;
        const int RANKDOWN = 5;
        const double STARTRATE = 0.01;
        const double CHANGE = 0.001;
        const double MAX = 0.03;
        const double MIN = 0.005;
        const int MONTHDAYS = 31;
        const string REPORT = "report.txt";
        public bool IsDirty;
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
            IsDirty = false;
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
                    var weight = rnd.Next(1000, 5000);
                    Product A = new Product()
                    {
                        Name = $"Product{j}",
                        Price = i * 10,
                        Type = (j % 2 == 0) ? "золото" : "серебро",
                        Weight = weight,
                        Sample = 999,
                        Image = noImage
                    };
                    Products.Add(A);
                    dep.Add(A);
                }
                Client B = new Client()
                {
                    Rank = 0,
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
            IsDirty = true;
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
            IsDirty = true;
        }

        public Client SearchClient(string email)
        {
            foreach (var cl in Clients)
            {
                if (cl.Email == email) return cl;
            }
            return null;
        }

        public double GetRate(Client client)
        {
            if (client.Rank < 0)
            {
                double temp = STARTRATE + ((-client.Rank - (-client.Rank % RANKDOWN)) / RANKDOWN * CHANGE);
                if (temp >= MAX) return MAX;
                else return temp;
            }
            else if (client.Rank == 0) return STARTRATE;
            else
            {
                double temp = STARTRATE - ((client.Rank - (client.Rank % RANKUP)) / RANKUP * CHANGE);
                if (temp <= MIN) return MIN;
                else return temp;
            }
        }

        public Deposit FindDepByName(string name)
        {
            foreach (var dep in Deposits)
            {
                if (dep.Name == name)
                    return dep;
            }
            return null;
        }

        public void GetReport()
        {
            using (var field = new StreamWriter(REPORT))
            {
                foreach (var dep in Deposits)
                {
                    field.WriteLine($"Имя депозита: {dep.Name}");
                    field.WriteLine($"Цена депозита: {dep.Price}");
                    field.WriteLine($"Кол-во вещей: {dep.Products.Count}");
                    field.WriteLine($"Процентная ставка: {GetRate(dep.Client) * 100}%");
                    field.WriteLine($"Имя клиента: {dep.Client.Name}");
                    field.WriteLine($"Дата создания: {dep.DateTime}");
                    field.WriteLine($"Последняя дата выкупа: {dep.DateTimeBuyOut}");
                    field.WriteLine();
                }
            }
        }

        public decimal GetPrice(Deposit dep, Client client)
        {
            return dep.Price + dep.Price * (DateTime.Now - dep.DateTime).Seconds * Convert.ToDecimal(GetRate(client));
        }

        public void Save()
        {
            new Dao(this).Save();
            IsDirty = false;
        }

        public void Load()
        {
            new Dao(this).Load();
        }
    }
}
