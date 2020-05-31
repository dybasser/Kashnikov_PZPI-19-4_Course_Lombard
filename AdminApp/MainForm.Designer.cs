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
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateCheck = new System.Windows.Forms.Button();
            this.DepositBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ForSaleGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ForSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Delete = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.RankButton = new System.Windows.Forms.Button();
            this.BanButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkDatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unreliableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForSaleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForSaleBindingSource)).BeginInit();
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
            this.ClientsGrid.Location = new System.Drawing.Point(12, 69);
            this.ClientsGrid.Name = "ClientsGrid";
            this.ClientsGrid.ReadOnly = true;
            this.ClientsGrid.RowHeadersVisible = false;
            this.ClientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsGrid.Size = new System.Drawing.Size(299, 399);
            this.ClientsGrid.TabIndex = 3;
            this.ClientsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClientsGrid_CellMouseDoubleClick);
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
            // DateCheck
            // 
            this.DateCheck.Location = new System.Drawing.Point(377, 474);
            this.DateCheck.Name = "DateCheck";
            this.DateCheck.Size = new System.Drawing.Size(106, 28);
            this.DateCheck.TabIndex = 4;
            this.DateCheck.Text = "Проверить даты";
            this.DateCheck.UseVisualStyleBackColor = true;
            this.DateCheck.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DepositBindingSource
            // 
            this.DepositBindingSource.DataSource = typeof(LibraryPawnShop.Models.Deposit);
            // 
            // ForSaleGrid
            // 
            this.ForSaleGrid.AllowUserToAddRows = false;
            this.ForSaleGrid.AllowUserToDeleteRows = false;
            this.ForSaleGrid.AutoGenerateColumns = false;
            this.ForSaleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ForSaleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.sampleDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.ForSaleGrid.DataSource = this.ForSaleBindingSource;
            this.ForSaleGrid.Location = new System.Drawing.Point(377, 69);
            this.ForSaleGrid.Name = "ForSaleGrid";
            this.ForSaleGrid.ReadOnly = true;
            this.ForSaleGrid.RowHeadersVisible = false;
            this.ForSaleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ForSaleGrid.Size = new System.Drawing.Size(309, 399);
            this.ForSaleGrid.TabIndex = 6;
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
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sampleDataGridViewTextBoxColumn
            // 
            this.sampleDataGridViewTextBoxColumn.DataPropertyName = "Sample";
            this.sampleDataGridViewTextBoxColumn.HeaderText = "Проба";
            this.sampleDataGridViewTextBoxColumn.Name = "sampleDataGridViewTextBoxColumn";
            this.sampleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Изображение";
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // ForSaleBindingSource
            // 
            this.ForSaleBindingSource.DataSource = typeof(LibraryPawnShop.Models.Product);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(616, 474);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(70, 28);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(489, 477);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(109, 23);
            this.ReportButton.TabIndex = 8;
            this.ReportButton.Text = "Получить отчёт";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // RankButton
            // 
            this.RankButton.Location = new System.Drawing.Point(12, 474);
            this.RankButton.Name = "RankButton";
            this.RankButton.Size = new System.Drawing.Size(87, 23);
            this.RankButton.TabIndex = 9;
            this.RankButton.Text = "Ненадёжные";
            this.RankButton.UseVisualStyleBackColor = true;
            this.RankButton.Click += new System.EventHandler(this.RankButton_Click);
            // 
            // BanButton
            // 
            this.BanButton.Location = new System.Drawing.Point(236, 474);
            this.BanButton.Name = "BanButton";
            this.BanButton.Size = new System.Drawing.Size(75, 23);
            this.BanButton.TabIndex = 10;
            this.BanButton.Text = "Забанить";
            this.BanButton.UseVisualStyleBackColor = true;
            this.BanButton.Click += new System.EventHandler(this.BanButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlToolStripMenuItem,
            this.warehouseToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.getReportToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.controlToolStripMenuItem.Text = "Управление";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.loadToolStripMenuItem.Text = "Загрузить";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // getReportToolStripMenuItem
            // 
            this.getReportToolStripMenuItem.Name = "getReportToolStripMenuItem";
            this.getReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.getReportToolStripMenuItem.Text = "Получить отчёт";
            this.getReportToolStripMenuItem.Click += new System.EventHandler(this.getReportToolStripMenuItem_Click);
            // 
            // warehouseToolStripMenuItem
            // 
            this.warehouseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkDatesToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            this.warehouseToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.warehouseToolStripMenuItem.Text = "Склад";
            // 
            // checkDatesToolStripMenuItem
            // 
            this.checkDatesToolStripMenuItem.Name = "checkDatesToolStripMenuItem";
            this.checkDatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkDatesToolStripMenuItem.Text = "Проверить даты";
            this.checkDatesToolStripMenuItem.Click += new System.EventHandler(this.checkDatesToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unreliableToolStripMenuItem,
            this.banToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.clientsToolStripMenuItem.Text = "Клиенты";
            // 
            // unreliableToolStripMenuItem
            // 
            this.unreliableToolStripMenuItem.Name = "unreliableToolStripMenuItem";
            this.unreliableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unreliableToolStripMenuItem.Text = "Ненадёжные";
            this.unreliableToolStripMenuItem.Click += new System.EventHandler(this.unreliableToolStripMenuItem_Click);
            // 
            // banToolStripMenuItem
            // 
            this.banToolStripMenuItem.Name = "banToolStripMenuItem";
            this.banToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.banToolStripMenuItem.Text = "Забанить";
            this.banToolStripMenuItem.Click += new System.EventHandler(this.banToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.exitToolStripMenuItem1.Text = "Выход";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(84, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Клиенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(483, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Склад";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BanButton);
            this.Controls.Add(this.RankButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ForSaleGrid);
            this.Controls.Add(this.DateCheck);
            this.Controls.Add(this.ClientsGrid);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(731, 560);
            this.MinimumSize = new System.Drawing.Size(731, 560);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Основное";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForSaleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForSaleBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ClientsGrid;
        private System.Windows.Forms.Button DateCheck;
        private System.Windows.Forms.BindingSource ClientBindingSource;
        private System.Windows.Forms.DataGridView ForSaleGrid;
        private System.Windows.Forms.BindingSource DepositBindingSource;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.BindingSource ForSaleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button RankButton;
        private System.Windows.Forms.Button BanButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkDatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unreliableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem getReportToolStripMenuItem;
    }
}

