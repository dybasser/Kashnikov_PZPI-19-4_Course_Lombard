using LibraryPawnShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class LoanForm : Form
    {
        List<Product> Products;

        const decimal goldCoeff = 0.9m;
        const decimal silverCoeff = 0.014m;
        const string GOLD = "gold";

        public LoanForm(List<Product> products)
        {
            InitializeComponent();
            if (products == null)
                Products = new List<Product>();
            else
                Products = products;
            GoldComboBox.Enabled = false;
            SilverComboBox.Enabled = false;
        }

        private decimal PriceFunc(string type, int sample, double weight)
        {
            decimal price;
            if (type == GOLD) price = sample * goldCoeff;
            else price = sample * silverCoeff;
            return price * Convert.ToDecimal(weight);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
        }

        private void TypeComboBox_TextChanged(object sender, EventArgs e)
        {
            if (TypeComboBox.Text == GOLD)
            {
                GoldComboBox.Enabled = true;
                SilverComboBox.Enabled = false;
            }
            else
            {
                GoldComboBox.Enabled = false;
                SilverComboBox.Enabled = true;
            }    
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || TypeComboBox.Text == "" || WeightField.Value == 0 || (GoldComboBox.Text == "" && SilverComboBox.Text == ""))
            {
                MessageBox.Show("You must fill all fields!");
                return;
            }
            else
            {
                string name = NameBox.Text;
                string type = TypeComboBox.Text;
                double weight = Convert.ToDouble(WeightField.Value);
                int sample;
                if (type == GOLD) sample = Convert.ToInt32(GoldComboBox.Text);
                else sample = Convert.ToInt32(SilverComboBox.Text);
                Products.Add(new Product()
                {
                    Name = name,
                    Type = type,
                    Weight = weight,
                    Sample = sample,
                    Image = pictureBox1.Image,
                    Price = PriceFunc(type, sample, weight)
                });
                DialogResult = DialogResult.OK;
                Close();
            }

            
        }

        private void chooseImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
            catch
            {
                MessageBox.Show("You must choose image file!(JPG, PNG, etc)");
            }
            
        }
    }
}
