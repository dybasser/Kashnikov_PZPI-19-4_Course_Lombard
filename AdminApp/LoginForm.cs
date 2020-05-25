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

namespace AdminApp
{
    public partial class LoginForm : Form
    {
        private string login;
        private string password;

        public LoginForm()
        {
            InitializeComponent();
            using (var rd = new StreamReader("admpass.txt"))
            {
                login = rd.ReadLine();
                password = rd.ReadLine();
            }
        }
        
        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == login && PasswordBox.Text == password)
            {
                MainForm main = new MainForm(this);
                main.Show();
                this.Visible = false;
            }
        }
    }
}
