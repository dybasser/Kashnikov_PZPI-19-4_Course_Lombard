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
    public partial class ClientInfoForm : Form
    {
        Client Client;
        PawnShop Shop;
        List<Deposit> Deposits;

        public ClientInfoForm(Client client, PawnShop shop)
        {
            InitializeComponent();
            Client = client;
            Shop = shop;
            InfoNameBox.Text = Client.Name;
            InfoAgeBox.Text = Convert.ToString(Client.Age);
            InfoEmailBox.Text = Client.Email;
            InfoPasswordBox.Text = Client.Password;
            Deposits = Shop.FindDeposits(Client);
            if (Deposits.Count != 0)
            {
                depositBindingSource.DataSource = Deposits;
                productBindingSource.DataSource = Deposits[0].Products;
                DateTimeBox.Text = Deposits[0].DateTime.ToString();
                DateTimeBuyOutBox.Text = Deposits[0].DateTimeBuyOut.ToString();
                
            }
        }

        private void DepositComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (var dep in Deposits)
            {
                if (dep.Name == DepositComboBox.Text)
                {
                    productBindingSource.DataSource = dep.Products;
                    DateTimeBox.Text = dep.DateTime.ToString();
                    DateTimeBuyOutBox.Text = dep.DateTimeBuyOut.ToString();
                }
            }
        }
    }
}
