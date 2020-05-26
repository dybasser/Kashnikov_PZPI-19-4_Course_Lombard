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

        public ClientInfoForm(Client client)
        {
            InitializeComponent();
            Client = client;
        }
    }
}
