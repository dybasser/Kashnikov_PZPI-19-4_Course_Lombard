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
        PawnShop Shop;
        LoginForm pred;

        public MainForm(LoginForm lg)
        {
            InitializeComponent();
            Shop = new PawnShop();
            //Shop.Load();
            Shop.FillTestData(50);
            pred = lg;
            //DepositBindingSource.DataSource = shop.Deposits;
            clientBindingSource.DataSource = Shop.Clients;
            depositBindingSource.DataSource = Shop.Deposits;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shop.Load();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shop.Save();
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
                    Shop.Save();
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
            int prev = Shop.ForSale.Count;
            Shop.DateCheck();
            if (prev < Shop.ForSale.Count)
            {
                foreach (var o in Shop.ForSale)
                {
                    ForSaleGrid.Rows.Add(o.Name);
                }
                depositBindingSource.DataSource = null;
                depositBindingSource.DataSource = Shop.Deposits;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ClientsGrid.Rows[0].Selected = false;
        }
    }
}
