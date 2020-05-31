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

namespace AdminApp
{
    public partial class ReportForm : Form
    {
        const string REPORT = "report.txt";
        


        public ReportForm(PawnShop shop, Deposit dep)
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            shop.GetTicket(dep);
            ReportBox.Text = File.ReadAllText(REPORT);
        }

        public ReportForm(PawnShop shop)
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            shop.GetReport();
            ReportBox.Text = File.ReadAllText(REPORT);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = saveFileDialog1.FileName;
            File.WriteAllText(fileName, ReportBox.Text);
            MessageBox.Show("Файл успешно сохранен!");
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
