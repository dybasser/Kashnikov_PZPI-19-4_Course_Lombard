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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "123" && PasswordBox.Text == "123")
            {
                MainForm main = new MainForm(this);
                main.Show();
                this.Visible = false;
            }
        }
    }
}
