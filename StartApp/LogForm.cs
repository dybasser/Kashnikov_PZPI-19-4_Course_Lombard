using AdminApp;
using ClientApp;
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

namespace StartApp
{
    public partial class LogForm : Form
    {
        string login;
        string password;

        public LogForm()
        {
            InitializeComponent();
            using (var rd = new StreamReader("pass.txt"))
            {
                login = rd.ReadLine();
                password = rd.ReadLine();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == login && textBox2.Text == password)
            {
                AdmForm adm = new AdmForm();
                this.Visible = false;
                adm.Show();
            }
            else
            {
                ClientForm client = new ClientForm();
                this.Visible = false;
                client.Show();
            }
        }
    }
}
