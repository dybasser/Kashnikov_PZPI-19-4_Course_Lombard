namespace AdminApp
{
    partial class MainForm
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
            this.ClientsGrid = new System.Windows.Forms.DataGridView();
            this.DateCheck = new System.Windows.Forms.Button();
            this.DepositsGrid = new System.Windows.Forms.DataGridView();
            this.ForSaleGrid = new System.Windows.Forms.DataGridView();
            this.ForSaleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ForSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeBuyOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepositBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RankButton = new System.Windows.Forms.Button();
            this.BanButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьДатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьРангиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.забанитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForSaleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientsGrid
            // 
            this.ClientsGrid.AllowUserToAddRows = false;
            this.ClientsGrid.AllowUserToDeleteRows = false;
            this.ClientsGrid.AutoGenerateColumns = false;
            this.ClientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn});
            this.ClientsGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClientsGrid.DataSource = this.ClientBindingSource;
            this.ClientsGrid.Location = new System.Drawing.Point(12, 27);
            this.ClientsGrid.Name = "ClientsGrid";
            this.ClientsGrid.ReadOnly = true;
            this.ClientsGrid.RowHeadersVisible = false;
            this.ClientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsGrid.Size = new System.Drawing.Size(299, 512);
            this.ClientsGrid.TabIndex = 3;
            this.ClientsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClientsGrid_CellMouseDoubleClick);
            this.ClientsGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ClientsGrid_RowsAdded);
            // 
            // DateCheck
            // 
            this.DateCheck.Location = new System.Drawing.Point(666, 545);
            this.DateCheck.Name = "DateCheck";
            this.DateCheck.Size = new System.Drawing.Size(106, 28);
            this.DateCheck.TabIndex = 4;
            this.DateCheck.Text = "CheckDate";
            this.DateCheck.UseVisualStyleBackColor = true;
            this.DateCheck.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DepositsGrid
            // 
            this.DepositsGrid.AllowUserToAddRows = false;
            this.DepositsGrid.AllowUserToDeleteRows = false;
            this.DepositsGrid.AutoGenerateColumns = false;
            this.DepositsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepositsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.dateTimeBuyOutDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn2});
            this.DepositsGrid.DataSource = this.DepositBindingSource;
            this.DepositsGrid.Location = new System.Drawing.Point(317, 27);
            this.DepositsGrid.Name = "DepositsGrid";
            this.DepositsGrid.ReadOnly = true;
            this.DepositsGrid.RowHeadersVisible = false;
            this.DepositsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepositsGrid.Size = new System.Drawing.Size(343, 512);
            this.DepositsGrid.TabIndex = 5;
            // 
            // ForSaleGrid
            // 
            this.ForSaleGrid.AllowUserToAddRows = false;
            this.ForSaleGrid.AllowUserToDeleteRows = false;
            this.ForSaleGrid.AutoGenerateColumns = false;
            this.ForSaleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ForSaleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ForSaleName,
            this.typeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.sampleDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.ForSaleGrid.DataSource = this.ForSaleBindingSource;
            this.ForSaleGrid.Location = new System.Drawing.Point(666, 27);
            this.ForSaleGrid.Name = "ForSaleGrid";
            this.ForSaleGrid.ReadOnly = true;
            this.ForSaleGrid.RowHeadersVisible = false;
            this.ForSaleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ForSaleGrid.Size = new System.Drawing.Size(240, 512);
            this.ForSaleGrid.TabIndex = 6;
            // 
            // ForSaleName
            // 
            this.ForSaleName.DataPropertyName = "Name";
            this.ForSaleName.HeaderText = "Name";
            this.ForSaleName.Name = "ForSaleName";
            this.ForSaleName.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(812, 545);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 28);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(958, 81);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(109, 23);
            this.ReportButton.TabIndex = 8;
            this.ReportButton.Text = "Получить отчёт";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sampleDataGridViewTextBoxColumn
            // 
            this.sampleDataGridViewTextBoxColumn.DataPropertyName = "Sample";
            this.sampleDataGridViewTextBoxColumn.HeaderText = "Sample";
            this.sampleDataGridViewTextBoxColumn.Name = "sampleDataGridViewTextBoxColumn";
            this.sampleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // ForSaleBindingSource
            // 
            this.ForSaleBindingSource.DataSource = typeof(LibraryPawnShop.Models.Product);
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateTimeBuyOutDataGridViewTextBoxColumn
            // 
            this.dateTimeBuyOutDataGridViewTextBoxColumn.DataPropertyName = "DateTimeBuyOut";
            this.dateTimeBuyOutDataGridViewTextBoxColumn.HeaderText = "DateTimeBuyOut";
            this.dateTimeBuyOutDataGridViewTextBoxColumn.Name = "dateTimeBuyOutDataGridViewTextBoxColumn";
            this.dateTimeBuyOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // DepositBindingSource
            // 
            this.DepositBindingSource.DataSource = typeof(LibraryPawnShop.Models.Deposit);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Почта";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "Rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Ранг";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ClientBindingSource
            // 
            this.ClientBindingSource.DataSource = typeof(LibraryPawnShop.Models.Client);
            // 
            // RankButton
            // 
            this.RankButton.Location = new System.Drawing.Point(13, 546);
            this.RankButton.Name = "RankButton";
            this.RankButton.Size = new System.Drawing.Size(75, 23);
            this.RankButton.TabIndex = 9;
            this.RankButton.Text = "button1";
            this.RankButton.UseVisualStyleBackColor = true;
            this.RankButton.Click += new System.EventHandler(this.RankButton_Click);
            // 
            // BanButton
            // 
            this.BanButton.Location = new System.Drawing.Point(178, 545);
            this.BanButton.Name = "BanButton";
            this.BanButton.Size = new System.Drawing.Size(75, 23);
            this.BanButton.TabIndex = 10;
            this.BanButton.Text = "Ban";
            this.BanButton.UseVisualStyleBackColor = true;
            this.BanButton.Click += new System.EventHandler(this.BanButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.складToolStripMenuItem,
            this.клиентыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проверитьДатыToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.складToolStripMenuItem.Text = "Склад";
            // 
            // проверитьДатыToolStripMenuItem
            // 
            this.проверитьДатыToolStripMenuItem.Name = "проверитьДатыToolStripMenuItem";
            this.проверитьДатыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.проверитьДатыToolStripMenuItem.Text = "Проверить даты";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проверитьРангиToolStripMenuItem,
            this.забанитьToolStripMenuItem});
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // проверитьРангиToolStripMenuItem
            // 
            this.проверитьРангиToolStripMenuItem.Name = "проверитьРангиToolStripMenuItem";
            this.проверитьРангиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.проверитьРангиToolStripMenuItem.Text = "Проверить ранги";
            // 
            // забанитьToolStripMenuItem
            // 
            this.забанитьToolStripMenuItem.Name = "забанитьToolStripMenuItem";
            this.забанитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.забанитьToolStripMenuItem.Text = "Забанить";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 577);
            this.Controls.Add(this.BanButton);
            this.Controls.Add(this.RankButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ForSaleGrid);
            this.Controls.Add(this.DepositsGrid);
            this.Controls.Add(this.DateCheck);
            this.Controls.Add(this.ClientsGrid);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Основное";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForSaleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ClientsGrid;
        private System.Windows.Forms.Button DateCheck;
        private System.Windows.Forms.DataGridView DepositsGrid;
        private System.Windows.Forms.BindingSource ClientBindingSource;
        private System.Windows.Forms.DataGridView ForSaleGrid;
        private System.Windows.Forms.BindingSource DepositBindingSource;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForSaleName;
        private System.Windows.Forms.BindingSource ForSaleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeBuyOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button RankButton;
        private System.Windows.Forms.Button BanButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверитьДатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверитьРангиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem забанитьToolStripMenuItem;
    }
}

