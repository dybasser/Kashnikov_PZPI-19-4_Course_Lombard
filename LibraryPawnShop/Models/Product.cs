using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPawnShop.Models
{
    [Serializable]
    public class Product
    {
        public string Type { set; get; }
        public decimal Price { set; get; }
        public string Name { set; get; }
        public double Weight { set; get; }
        const string Unit = "g";
        public int Sample { get; set; }
        public Image Image { set; get; }
    }
}
