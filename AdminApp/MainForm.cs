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
    public partial class MainForm : Form
    {
        PawnShop shop;
        LoginForm pred;

        public MainForm(LoginForm lg)
        {
            InitializeComponent();
            shop = new PawnShop();
            shop.FillTestData(100);
            pred = lg;
            //DepositBindingSource.DataSource = shop.Deposits;
            clientBindingSource.DataSource = shop.Clients;
            productBindingSource.DataSource = shop.Products;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shop.Load();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shop.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // есть ли изменённые данные
            var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    shop.Save();
                    pred.Close();
                    break;
                case DialogResult.No:
                    pred.Close();
                    break;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var pf = new ProductForm();
            //if (pf.ShowDialog() == DialogResult.OK)
            //{
            //    shop.Products.Add(pf.Product);
                
            //}
            //productBindingSource.ResetBindings(false);
        }

        private void productList_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Vsem hai");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            shop.DateCheck();
        }
    }
}
