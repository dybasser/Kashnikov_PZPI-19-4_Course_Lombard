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
        PawnShop Shop;
        const string filePath = "shop.bin";

        public Dao(PawnShop shop)
        {
            Shop = shop;
        }

        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, Shop);
            }
        }

        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                PawnShop sh = (PawnShop)serializer.Deserialize(stream);
                Copy(sh.Products, Shop.Products);
                Copy(sh.Clients, Shop.Clients);
                Copy(sh.Deposits, Shop.Deposits);
                Copy(sh.Warehouse, Shop.Warehouse);
                Copy(sh.BannedUsers, Shop.BannedUsers);
            }
        }
        private void Copy<T>(List<T> from, List<T> to)
        {
            to.Clear();
            to.AddRange(from);
        }
    }
}
