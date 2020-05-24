using LibraryPawnShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class ProductForm : Form
    {
        public Product Product { set; get; }

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var p = new Product
            {
                Name = nameBox.Text,
                Unit = unitBox.Text,
                Price = priceBox.Value
            };
            p.Id = p.GetHashCode();
        }
    }
}
