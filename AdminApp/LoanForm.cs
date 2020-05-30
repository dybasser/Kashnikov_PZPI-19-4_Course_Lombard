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
    public partial class LoanForm : Form
    {
        List<Product> Products;

        public LoanForm(List<Product> products)
        {
            InitializeComponent();
            Products = products;
           
        }
    }
}
