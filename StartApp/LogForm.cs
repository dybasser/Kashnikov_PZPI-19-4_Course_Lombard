using LibraryPawnShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminApp;
using System.Net.Mail;

namespace StartApp
{
    public partial class LogForm : Form
    {
        const string adminPass = "pass.txt";

        string admlogin;
        string admpassword;

        PawnShop Shop;

        public LogForm()
        {
            InitializeComponent();
            Shop = new PawnShop();
            if (File.Exists("shop.bin"))
                Shop.Load();
            //Shop.FillTestData(100);
            using (var rd = new StreamReader(adminPass))
            {
                admlogin = rd.ReadLine();
                admpassword = rd.ReadLine();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmailBox.Text == admlogin && PasswordBox.Text == admpassword)
            {
                MainForm adm = new MainForm(Shop);
                Hide();
                EmailBox.Text = "";
                PasswordBox.Text = "";
                adm.Show();
            }
            else
            {
                string email = EmailBox.Text;
                string password = PasswordBox.Text;
                Client client = Shop.SearchClient(email);
                if (client != null && client.Password == password)
                {
                    ClientInfoForm clientF = new ClientInfoForm(client, Shop, true);
                    Hide();
                    EmailBox.Text = "";
                    PasswordBox.Text = "";
                    clientF.Show();
                }
                else
                {
                    MessageBox.Show("Wrong");
                }
                    
            }
        }

        private void SingUpButton_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm(Shop.Clients);
            this.Visible = false;
            if (reg.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
                Shop.Save();
            }
        }
    }
}
