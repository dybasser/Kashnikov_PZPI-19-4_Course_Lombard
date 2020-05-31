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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Shop.IsDirty == true)
            {
                var res = MessageBox.Show("Сохраниться перед выходом?", "", MessageBoxButtons.YesNoCancel);
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
            else
            {
                Application.OpenForms[0].Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int n = Shop.ForSale.Count;
            Shop.DateCheck();
            if (Shop.ForSale.Count > n)
            {
                DepositBindingSource.ResetBindings(false);
                ForSaleBindingSource.ResetBindings(false);
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
                ForSaleBindingSource.ResetBindings(false);
            }
            catch
            {
                MessageBox.Show("Список пуст!");
            }
            
        }

        private void ClientsGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Client client = Shop.SearchClient((string)ClientsGrid.SelectedRows[0].Cells[1].Value);
                ClientInfoForm clientInfoForm = new ClientInfoForm(client, Shop);
                clientInfoForm.ShowDialog();
            }
            catch
            {

            }
            
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            Form report = new ReportForm(Shop);
            report.ShowDialog();
        }

        private void ClientsGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void RankButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClientsGrid.Rows.Count; ++i)
            {
                if ((int)ClientsGrid["rankDataGridViewTextBoxColumn", i].Value < -5)
                    ClientsGrid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void BanButton_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = Shop.SearchClient((string)ClientsGrid.SelectedRows[0].Cells[0].Value);
                foreach (var dep in Shop.Deposits)
                {
                    if (dep.Client == client)
                    {
                        dep.DateTimeBuyOut = dep.DateTime;
                    }
                }
                DateCheck.PerformClick();
                Shop.BannedUsers.Add(client.Email);
                Shop.Clients.Remove(client);
                ClientBindingSource.ResetBindings(false);
            }
            catch
            {

            }
        }
    }
}
