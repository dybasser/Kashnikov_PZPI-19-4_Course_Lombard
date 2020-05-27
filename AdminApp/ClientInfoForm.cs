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

        public ClientInfoForm(Client client, PawnShop shop, bool IsClient = false)
        {
            InitializeComponent();
            Client = client;
            Shop = shop;
            if (IsClient == false)
            {
                InfoNameBox.Text = Client.Name;
                InfoAgeBox.Text = Convert.ToString(Client.Age);
                InfoEmailBox.Text = Client.Email;
                InfoPasswordBox.Text = Client.Password;
                DepComboBoxLabel.Text = "Deposits";
            }
            else
            {
                InfoNameBox.Visible = false;
                InfoAgeBox.Visible = false;
                InfoEmailBox.Visible = false;
                InfoPasswordBox.Visible = false;
                InfoRankBox.Visible = false;
                AgeLabel.Visible = false;
                NameLabel.Visible = false;
                PasswordLabel.Visible = false;
                EmailLabel.Visible = false;
                RankLabel.Visible = false;
            }
            Deposits = Shop.FindDepositsByClient(Client);
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

        private void BuyOut_Click(object sender, EventArgs e)
        {
            string name = DepositComboBox.Text;
            if (DepositComboBox.Text != "")
            {
                Shop.Deposits.RemoveAt(Shop.IndOfDepByName(name));
                Deposits = Shop.FindDepositsByClient(Client);
                depositBindingSource.DataSource = Deposits;
                //productBindingSource.ResetBindings(true);
            }
        }
    }
}
