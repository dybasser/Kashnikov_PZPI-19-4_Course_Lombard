using LibraryPawnShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class MainForm : Form
    {
        PawnShop Shop;
        

        public MainForm(PawnShop shop)
        {
            InitializeComponent();
            Shop = shop;
            ClientBindingSource.DataSource = Shop.Clients;
            DepositBindingSource.DataSource = Shop.Deposits;
            ForSaleBindingSource.DataSource = Shop.ForSale;
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
            if (Shop.IsDirty != true)
            {
                var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        Shop.Save();
                        Application.OpenForms[0].Close();
                        break;
                    case DialogResult.No:
                        Application.OpenForms[0].Close();
                        break;
                }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            int n = Shop.ForSale.Count;
            Shop.DateCheck();
            if (Shop.ForSale.Count > n)
            {
                DepositBindingSource.ResetBindings(true);
                ForSaleBindingSource.ResetBindings(true);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ClientsGrid.Rows[0].Selected = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string item = (string)ForSaleGrid.SelectedRows[0].Cells[0].Value;
                Shop.ForSaleDelete(item);
                ForSaleBindingSource.ResetBindings(true);
            }
            catch
            {

            }
            
        }

        private void ClientsGrid_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //while (ClientsGrid.SelectedRows.Count != 0)
            //    ClientsGrid.SelectedRows[0].Selected = false;
        }

        private void ClientsGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Client client = Shop.SearchClient((string)ClientsGrid.SelectedRows[0].Cells[0].Value);
                ClientInfoForm clientInfoForm = new ClientInfoForm(client, Shop);
                clientInfoForm.ShowDialog();
            }
            catch
            {

            }
            
        }

        private void ClientsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show("cho");
        }

        private void ClientsGrid_ColumnDividerDoubleClick(object sender, DataGridViewColumnDividerDoubleClickEventArgs e)
        {
            //MessageBox.Show("right");
        }
    }
}
