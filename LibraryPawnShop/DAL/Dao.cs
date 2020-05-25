using LibraryPawnShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPawnShop.DAL
{
    public class Dao
    {
        PawnShop shop;
        const string filePath = "shop.bin";

        public Dao(PawnShop shop)
        {
            this.shop = shop;
        }

        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, shop);
            }
        }

        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                PawnShop sh = (PawnShop)serializer.Deserialize(stream);
                Copy(sh.Products, shop.Products);
                Copy(sh.Clients, shop.Clients);
                Copy(sh.Deposits, shop.Deposits);
                Copy(sh.ForSale, shop.ForSale);
            }
        }
        private void Copy<T>(List<T> from, List<T> to)
        {
            to.Clear();
            to.AddRange(from);
        }
    }
}
