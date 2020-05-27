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

namespace StartApp
{
    public partial class LogForm : Form
    {
        string admlogin;
        string admpassword;

        PawnShop Shop;

        public LogForm()
        {
            InitializeComponent();
            Shop = new PawnShop();
            if (File.Exists("shop.bin"))
                Shop.Load();
            //Shop.FillTestData(50);
            using (var rd = new StreamReader("pass.txt"))
            {
                admlogin = rd.ReadLine();
                admpassword = rd.ReadLine();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == admlogin && textBox2.Text == admpassword)
            {
                MainForm adm = new MainForm(Shop);
                this.Visible = false;
                adm.Show();
            }
            else
            {
                string login = textBox1.Text;
                string password = textBox2.Text;
                Client client = Shop.SearchClient(login);
                if (client != null && client.Password == password)
                {
                    ClientInfoForm clientF = new ClientInfoForm(client, Shop, true);
                    this.Visible = false;
                    clientF.Show();
                }
                else
                    MessageBox.Show("Wrong");
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
