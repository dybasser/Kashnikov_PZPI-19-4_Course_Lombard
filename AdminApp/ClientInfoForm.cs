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
        PawnShop Shop;
        List<Deposit> Deposits;
        List<Product> Products = new List<Product>();
        bool IsClient;

        public ClientInfoForm(Client client, PawnShop shop, bool isClient = false)
        {
            InitializeComponent();
            Client = client;
            Shop = shop;
            IsClient = isClient;
            productBindingSource1.DataSource = Products;
            if (IsClient == false)
            {
                Text = "Информация о клиенте";
                InfoNameBox.Text = Client.Name;
                InfoAgeBox.Text = Convert.ToString(Client.Age);
                InfoEmailBox.Text = Client.Email;
                InfoPasswordBox.Text = Client.Password;
                InfoRankBox.Text = Convert.ToString(Client.Rank);
                BuyOutButton.Hide();
                LoanBox.Hide();
                menuStrip.Hide();
            }
            else
            {
                Text = "Основное";
                MainInfoBox.Hide();
                CurrentDeposit.Show();
            }
            Deposits = Shop.FindDepositsByClient(Client);
            if (Deposits.Count != 0)
            {
                depositBindingSource.DataSource = Deposits;
                productBindingSource.DataSource = Deposits[0].Products;
                DateTimeBox.Text = Deposits[0].DateTime.ToString();
                DateTimeBuyOutBox.Text = Deposits[0].DateTimeBuyOut.ToString();
                PriceBox.Text = Deposits[0].Price.ToString();

            }
            else
                BuyOutButton.Enabled = false;
        }

        private void DepositComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (var dep in Deposits)
            {
                if (dep.Name == DepositComboBox.Text)
                {
                    productBindingSource.ResetBindings(false);
                    productBindingSource.DataSource = dep.Products;
                    DateTimeBox.Text = dep.DateTime.ToString();
                    DateTimeBuyOutBox.Text = dep.DateTimeBuyOut.ToString();
                    PriceBox.Text = dep.Price.ToString();
                }
            }

        }

        private void BuyOut_Click(object sender, EventArgs e)
        {
            if (Shop.Deposits[Shop.IndOfDepByName(DepositComboBox.Text)].DateTimeBuyOut <= DateTime.Now)
            {
                MessageBox.Show("Срок кредита истёк!");
                --Client.Rank;
                Shop.Deposits.RemoveAt(Shop.IndOfDepByName(DepositComboBox.Text));
                Deposits = Shop.FindDepositsByClient(Client);
                depositBindingSource.DataSource = Deposits;
                if (Deposits.Count != 0)
                    productBindingSource.DataSource = Shop.Deposits[Shop.IndOfDepByName(DepositComboBox.Text)].Products;
                else
                {
                    productBindingSource.DataSource = null;
                    DateTimeBox.Clear();
                    DateTimeBuyOutBox.Clear();
                    PriceBox.Clear();
                }
                return;
            }
            var res = MessageBox.Show($"К оплате {Shop.GetPrice(Shop.FindDepByName(DepositComboBox.Text), Client)} грн. Подтвердить действие?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string name = DepositComboBox.Text;
                if (DepositComboBox.Text != "")
                {
                    Shop.Deposits.RemoveAt(Shop.IndOfDepByName(name));
                    Deposits = Shop.FindDepositsByClient(Client);
                    depositBindingSource.DataSource = Deposits;
                    if (Deposits.Count != 0)
                        productBindingSource.DataSource = Shop.Deposits[Shop.IndOfDepByName(DepositComboBox.Text)].Products;
                    else
                    {
                        productBindingSource.DataSource = null;
                        DateTimeBox.Clear();
                        DateTimeBuyOutBox.Clear();
                        PriceBox.Clear();
                    }
                }
                Shop.IsDirty = true;
                ++Client.Rank;
            }
            if (Deposits.Count == 0) BuyOutButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoanForm loan = new LoanForm(Products);
            if (loan.ShowDialog() == DialogResult.OK)
            {
                productBindingSource1.ResetBindings(false);
                GetLoan.Enabled = true;
            }
            DeleteButton.Enabled = true;
        }

        private void ClientInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Shop.IsDirty == true)
            {
                var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        Shop.Save();
                        Application.OpenForms[0].Close();
                        break;
                    case DialogResult.No:
                        Application.OpenForms[0].Close();
                        break;
                }
            }
            else  
            {
                Application.OpenForms[0].Show();
            }
        }

        private void GetLoan_Click(object sender, EventArgs e)
        {
            if (DepositName.Text == "")
            {
                MessageBox.Show("Введите имя депозита!");
                return;
            }
            else if (Shop.IndOfDepByName(DepositName.Text) != -1)
            {
                MessageBox.Show("Депозит с таким именем уже существует! Попробуйте другое!");
                DepositName.Clear();
                return;
            }
            string name = DepositName.Text;
            Deposit dep = new Deposit(Products, Client) { Name = name};
            MessageBox.Show("Срок кредита: 60 дней\n" +
                $"Размер кредита: {dep.Price} грн\n" +
                $"Процентная ставка: {Shop.GetRate(Client)*100}%");
            if (MessageBox.Show("Вы желаете сохранить залоговый билет?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form ticket = new ReportForm(Shop, dep);
                ticket.ShowDialog();
            }
            Shop.Deposits.Add(dep);
            Products.Clear();
            productBindingSource1.ResetBindings(false);
            Deposits = Shop.FindDepositsByClient(Client);
            depositBindingSource.DataSource = Deposits;
            Shop.IsDirty = true;
            BuyOutButton.Enabled = true;
            GetLoan.Enabled = false;
            DepositName.Clear();
            if (Deposits.Count == 1)
            {
                productBindingSource.DataSource = Deposits[0].Products;
                DateTimeBox.Text = Deposits[0].DateTime.ToString();
                DateTimeBuyOutBox.Text = Deposits[0].DateTimeBuyOut.ToString();
                PriceBox.Text = Deposits[0].Price.ToString();
            }
               
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Products.Count != 0)
            {
                string name = (string)CurrentDeposit.Rows[0].Cells[0].Value;
                for (int i = 0; i < Products.Count; ++i)
                {
                    if (Products[i].Name == name)
                    {
                        Products.RemoveAt(i);
                        productBindingSource1.ResetBindings(false);
                        break;
                    }
                }
            }

            if (Products.Count == 0) DeleteButton.Enabled = false;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct.PerformClick();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteButton.PerformClick();
        }

        private void создатьДепозитToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetLoan.PerformClick();
        }

        private void вернутьЗаймToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyOutButton.PerformClick();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Close();
        }
    }
}
