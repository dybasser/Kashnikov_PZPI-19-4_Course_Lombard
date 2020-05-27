using AdminApp;
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

namespace ClientApp
{
    public partial class ClientForm : Form
    {
        Client Client;
        PawnShop Shop;

        public ClientForm(Client client, PawnShop shop)
        {
            InitializeComponent();
            Client = client;
            Shop = shop;
        }

        public ClientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientInfoForm clientInfo = new ClientInfoForm(Client, Shop);
            clientInfo.Show();
        }
    }
}
