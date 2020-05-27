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

namespace StartApp
{
    public partial class RegForm : Form
    {
        List<Client> Clients;

        public RegForm(List<Client> clients)
        {
            InitializeComponent();
            Clients = clients;
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            Clients.Add(new Client()
            {
                Name = NameBox.Text,
                Email = EmailBox.Text,
                Age = Convert.ToInt32(AgeBox.Text),
                Password = PasswordBox.Text,
                Rank = 0
            });
            this.Close();
        }
    }
}
