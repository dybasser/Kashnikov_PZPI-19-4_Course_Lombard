using System;
using pawnShop.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pawnShop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PawnShop shop = new PawnShop();
            //shop.FillTestData(100);
            //shop.Save();
            //shop.ForSales.Clear();
            shop.Load();
            Console.WriteLine(shop.ForSales[0].Products[0].Id);
            Console.ReadKey();



            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
