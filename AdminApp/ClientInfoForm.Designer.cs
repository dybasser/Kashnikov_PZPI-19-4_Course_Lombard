namespace AdminApp
{
    partial class ClientInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DepositComboBox = new System.Windows.Forms.ComboBox();
            this.depositBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InfoNameBox = new System.Windows.Forms.TextBox();
            this.InfoEmailBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.InfoPasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.InfoAgeBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.InfoRankBox = new System.Windows.Forms.TextBox();
            this.RankLabel = new System.Windows.Forms.Label();
            this.DepComboBoxLabel = new System.Windows.Forms.Label();
            this.ProductGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateTimeBox = new System.Windows.Forms.TextBox();
            this.DateTimeBuyOutBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BuyOutButton = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.MainInfoBox = new System.Windows.Forms.GroupBox();
            this.CurrentDeposit = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GetLoan = new System.Windows.Forms.Button();
            this.DepositName = new System.Windows.Forms.TextBox();
            this.LoanBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.текущийДепозитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.MainInfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.LoanBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepositComboBox
            // 
            this.DepositComboBox.DataSource = this.depositBindingSource;
            this.DepositComboBox.DisplayMember = "Name";
            this.DepositComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepositComboBox.FormattingEnabled = true;
            this.DepositComboBox.Location = new System.Drawing.Point(474, 53);
            this.DepositComboBox.Name = "DepositComboBox";
            this.DepositComboBox.Size = new System.Drawing.Size(196, 21);
            this.DepositComboBox.TabIndex = 11;
            this.DepositComboBox.ValueMember = "Name";
            this.DepositComboBox.SelectionChangeCommitted += new System.EventHandler(this.DepositComboBox_SelectionChangeCommitted);
            // 
            // depositBindingSource
            // 
            this.depositBindingSource.DataSource = typeof(LibraryPawnShop.Models.Deposit);
            // 
            // InfoNameBox
            // 
            this.InfoNameBox.Location = new System.Drawing.Point(6, 40);
            this.InfoNameBox.Name = "InfoNameBox";
            this.InfoNameBox.ReadOnly = true;
            this.InfoNameBox.Size = new System.Drawing.Size(246, 20);
            this.InfoNameBox.TabIndex = 1;
            // 
            // InfoEmailBox
            // 
            this.InfoEmailBox.Location = new System.Drawing.Point(6, 103);
            this.InfoEmailBox.Name = "InfoEmailBox";
            this.InfoEmailBox.ReadOnly = true;
            this.InfoEmailBox.Size = new System.Drawing.Size(245, 20);
            this.InfoEmailBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 24);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Имя";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(6, 87);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(37, 13);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Почта";
            // 
            // InfoPasswordBox
            // 
            this.InfoPasswordBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InfoPasswordBox.Location = new System.Drawing.Point(5, 168);
            this.InfoPasswordBox.Name = "InfoPasswordBox";
            this.InfoPasswordBox.ReadOnly = true;
            this.InfoPasswordBox.Size = new System.Drawing.Size(246, 20);
            this.InfoPasswordBox.TabIndex = 5;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(6, 152);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Пароль";
            // 
            // InfoAgeBox
            // 
            this.InfoAgeBox.Location = new System.Drawing.Point(5, 230);
            this.InfoAgeBox.Name = "InfoAgeBox";
            this.InfoAgeBox.ReadOnly = true;
            this.InfoAgeBox.Size = new System.Drawing.Size(39, 20);
            this.InfoAgeBox.TabIndex = 7;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(6, 214);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(49, 13);
            this.AgeLabel.TabIndex = 8;
            this.AgeLabel.Text = "Возраст";
            // 
            // InfoRankBox
            // 
            this.InfoRankBox.Location = new System.Drawing.Point(6, 296);
            this.InfoRankBox.Name = "InfoRankBox";
            this.InfoRankBox.ReadOnly = true;
            this.InfoRankBox.Size = new System.Drawing.Size(39, 20);
            this.InfoRankBox.TabIndex = 9;
            // 
            // RankLabel
            // 
            this.RankLabel.AutoSize = true;
            this.RankLabel.Location = new System.Drawing.Point(6, 280);
            this.RankLabel.Name = "RankLabel";
            this.RankLabel.Size = new System.Drawing.Size(31, 13);
            this.RankLabel.TabIndex = 10;
            this.RankLabel.Text = "Ранг";
            // 
            // DepComboBoxLabel
            // 
            this.DepComboBoxLabel.AutoSize = true;
            this.DepComboBoxLabel.Location = new System.Drawing.Point(474, 34);
            this.DepComboBoxLabel.Name = "DepComboBoxLabel";
            this.DepComboBoxLabel.Size = new System.Drawing.Size(59, 13);
            this.DepComboBoxLabel.TabIndex = 12;
            this.DepComboBoxLabel.Text = "Депозиты";
            // 
            // ProductGrid
            // 
            this.ProductGrid.AllowUserToAddRows = false;
            this.ProductGrid.AllowUserToDeleteRows = false;
            this.ProductGrid.AutoGenerateColumns = false;
            this.ProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.sampleDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.Image});
            this.ProductGrid.DataSource = this.productBindingSource;
            this.ProductGrid.Location = new System.Drawing.Point(371, 181);
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.ReadOnly = true;
            this.ProductGrid.RowHeadersVisible = false;
            this.ProductGrid.RowTemplate.Height = 35;
            this.ProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGrid.Size = new System.Drawing.Size(323, 257);
            this.ProductGrid.TabIndex = 13;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sampleDataGridViewTextBoxColumn
            // 
            this.sampleDataGridViewTextBoxColumn.DataPropertyName = "Sample";
            this.sampleDataGridViewTextBoxColumn.HeaderText = "Проба";
            this.sampleDataGridViewTextBoxColumn.Name = "sampleDataGridViewTextBoxColumn";
            this.sampleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена(грн)";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Изображение";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(LibraryPawnShop.Models.Product);
            // 
            // DateTimeBox
            // 
            this.DateTimeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateTimeBox.Location = new System.Drawing.Point(371, 116);
            this.DateTimeBox.Name = "DateTimeBox";
            this.DateTimeBox.ReadOnly = true;
            this.DateTimeBox.Size = new System.Drawing.Size(137, 20);
            this.DateTimeBox.TabIndex = 14;
            // 
            // DateTimeBuyOutBox
            // 
            this.DateTimeBuyOutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateTimeBuyOutBox.Location = new System.Drawing.Point(533, 116);
            this.DateTimeBuyOutBox.Name = "DateTimeBuyOutBox";
            this.DateTimeBuyOutBox.ReadOnly = true;
            this.DateTimeBuyOutBox.Size = new System.Drawing.Size(137, 20);
            this.DateTimeBuyOutBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Дата создания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Последняя дата выкупа";
            // 
            // BuyOutButton
            // 
            this.BuyOutButton.Location = new System.Drawing.Point(359, 53);
            this.BuyOutButton.Name = "BuyOutButton";
            this.BuyOutButton.Size = new System.Drawing.Size(96, 23);
            this.BuyOutButton.TabIndex = 18;
            this.BuyOutButton.Text = "Вернуть займ";
            this.BuyOutButton.UseVisualStyleBackColor = true;
            this.BuyOutButton.Click += new System.EventHandler(this.BuyOut_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(15, 23);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(75, 23);
            this.AddProduct.TabIndex = 19;
            this.AddProduct.Text = "Добавить";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainInfoBox
            // 
            this.MainInfoBox.Controls.Add(this.InfoNameBox);
            this.MainInfoBox.Controls.Add(this.NameLabel);
            this.MainInfoBox.Controls.Add(this.InfoEmailBox);
            this.MainInfoBox.Controls.Add(this.EmailLabel);
            this.MainInfoBox.Controls.Add(this.InfoPasswordBox);
            this.MainInfoBox.Controls.Add(this.PasswordLabel);
            this.MainInfoBox.Controls.Add(this.InfoAgeBox);
            this.MainInfoBox.Controls.Add(this.AgeLabel);
            this.MainInfoBox.Controls.Add(this.InfoRankBox);
            this.MainInfoBox.Controls.Add(this.RankLabel);
            this.MainInfoBox.Location = new System.Drawing.Point(12, 25);
            this.MainInfoBox.Name = "MainInfoBox";
            this.MainInfoBox.Size = new System.Drawing.Size(341, 425);
            this.MainInfoBox.TabIndex = 20;
            this.MainInfoBox.TabStop = false;
            this.MainInfoBox.Text = "Основная информация";
            // 
            // CurrentDeposit
            // 
            this.CurrentDeposit.AllowUserToAddRows = false;
            this.CurrentDeposit.AllowUserToDeleteRows = false;
            this.CurrentDeposit.AutoGenerateColumns = false;
            this.CurrentDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentDeposit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.weightDataGridViewTextBoxColumn1,
            this.sampleDataGridViewTextBoxColumn1,
            this.imageDataGridViewImageColumn});
            this.CurrentDeposit.DataSource = this.productBindingSource1;
            this.CurrentDeposit.Location = new System.Drawing.Point(15, 48);
            this.CurrentDeposit.Name = "CurrentDeposit";
            this.CurrentDeposit.ReadOnly = true;
            this.CurrentDeposit.RowHeadersVisible = false;
            this.CurrentDeposit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CurrentDeposit.Size = new System.Drawing.Size(271, 257);
            this.CurrentDeposit.TabIndex = 21;
            this.CurrentDeposit.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Цена(грн)";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn1
            // 
            this.weightDataGridViewTextBoxColumn1.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn1.HeaderText = "Вес";
            this.weightDataGridViewTextBoxColumn1.Name = "weightDataGridViewTextBoxColumn1";
            this.weightDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sampleDataGridViewTextBoxColumn1
            // 
            this.sampleDataGridViewTextBoxColumn1.DataPropertyName = "Sample";
            this.sampleDataGridViewTextBoxColumn1.HeaderText = "Проба";
            this.sampleDataGridViewTextBoxColumn1.Name = "sampleDataGridViewTextBoxColumn1";
            this.sampleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Изображение";
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(LibraryPawnShop.Models.Product);
            // 
            // GetLoan
            // 
            this.GetLoan.Enabled = false;
            this.GetLoan.Location = new System.Drawing.Point(182, 335);
            this.GetLoan.Name = "GetLoan";
            this.GetLoan.Size = new System.Drawing.Size(104, 23);
            this.GetLoan.TabIndex = 22;
            this.GetLoan.Text = "Создать депозит";
            this.GetLoan.UseVisualStyleBackColor = true;
            this.GetLoan.Click += new System.EventHandler(this.GetLoan_Click);
            // 
            // DepositName
            // 
            this.DepositName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepositName.Location = new System.Drawing.Point(15, 338);
            this.DepositName.Name = "DepositName";
            this.DepositName.Size = new System.Drawing.Size(100, 20);
            this.DepositName.TabIndex = 23;
            // 
            // LoanBox
            // 
            this.LoanBox.Controls.Add(this.DeleteButton);
            this.LoanBox.Controls.Add(this.label1);
            this.LoanBox.Controls.Add(this.AddProduct);
            this.LoanBox.Controls.Add(this.GetLoan);
            this.LoanBox.Controls.Add(this.DepositName);
            this.LoanBox.Controls.Add(this.CurrentDeposit);
            this.LoanBox.Location = new System.Drawing.Point(6, 30);
            this.LoanBox.Name = "LoanBox";
            this.LoanBox.Size = new System.Drawing.Size(341, 426);
            this.LoanBox.TabIndex = 24;
            this.LoanBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Имя депозита";
            // 
            // PriceBox
            // 
            this.PriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceBox.Location = new System.Drawing.Point(465, 142);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ReadOnly = true;
            this.PriceBox.Size = new System.Drawing.Size(100, 20);
            this.PriceBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Цена(грн)";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(211, 22);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 25;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.Delete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текущийДепозитToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // текущийДепозитToolStripMenuItem
            // 
            this.текущийДепозитToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.текущийДепозитToolStripMenuItem.Name = "текущийДепозитToolStripMenuItem";
            this.текущийДепозитToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.текущийДепозитToolStripMenuItem.Text = "Текущий депозит";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // ClientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 468);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.LoanBox);
            this.Controls.Add(this.MainInfoBox);
            this.Controls.Add(this.BuyOutButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTimeBuyOutBox);
            this.Controls.Add(this.DateTimeBox);
            this.Controls.Add(this.ProductGrid);
            this.Controls.Add(this.DepComboBoxLabel);
            this.Controls.Add(this.DepositComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientInfoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientInfoForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.MainInfoBox.ResumeLayout(false);
            this.MainInfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.LoanBox.ResumeLayout(false);
            this.LoanBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InfoNameBox;
        private System.Windows.Forms.TextBox InfoEmailBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox InfoPasswordBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox InfoAgeBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox InfoRankBox;
        private System.Windows.Forms.Label RankLabel;
        private System.Windows.Forms.BindingSource depositBindingSource;
        private System.Windows.Forms.Label DepComboBoxLabel;
        private System.Windows.Forms.DataGridView ProductGrid;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox DateTimeBox;
        private System.Windows.Forms.TextBox DateTimeBuyOutBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DepositComboBox;
        private System.Windows.Forms.Button BuyOutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.GroupBox MainInfoBox;
        private System.Windows.Forms.DataGridView CurrentDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button GetLoan;
        private System.Windows.Forms.TextBox DepositName;
        private System.Windows.Forms.GroupBox LoanBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem текущийДепозитToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}