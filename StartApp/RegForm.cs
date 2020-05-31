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
        List<string> Banned;

        public RegForm(List<Client> clients, List<string> banned)
        {
            InitializeComponent();
            Clients = clients;
            Banned = banned;
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (Banned.Contains(EmailBox.Text))
            {
                MessageBox.Show("Регистрация невозможна. Почта забанена.");
            }
            else if (NameBox.Text == "" || EmailBox.Text == "" || PasswordBox.Text == "")
            {
                MessageBox.Show("Заполните поля корректно!");
            }
            
            else
            {
                try
                {
                    Clients.Add(new Client()
                    {
                        Name = NameBox.Text,
                        Email = EmailBox.Text,
                        Age = Convert.ToInt32(AgeBox.Text),
                        Password = PasswordBox.Text,
                        Rank = 0
                    });
                    Close();
                }
                catch
                {
                    MessageBox.Show("Заполните поля корректно!");
                }
            }
        }
    }
}
