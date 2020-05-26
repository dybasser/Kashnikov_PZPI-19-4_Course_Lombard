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
            this.LabelInfoName = new System.Windows.Forms.Label();
            this.LabelInfoEmail = new System.Windows.Forms.Label();
            this.InfoPasswordBox = new System.Windows.Forms.TextBox();
            this.LabelInfoPassword = new System.Windows.Forms.Label();
            this.InfoAgeBox = new System.Windows.Forms.TextBox();
            this.LabelInfoAge = new System.Windows.Forms.Label();
            this.InfoRankBox = new System.Windows.Forms.TextBox();
            this.LabelInfoRank = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateTimeBox = new System.Windows.Forms.TextBox();
            this.DateTimeBuyOutBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
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
            this.InfoNameBox.Location = new System.Drawing.Point(12, 53);
            this.InfoNameBox.Name = "InfoNameBox";
            this.InfoNameBox.ReadOnly = true;
            this.InfoNameBox.Size = new System.Drawing.Size(246, 20);
            this.InfoNameBox.TabIndex = 1;
            this.InfoNameBox.TabStop = false;
            // 
            // InfoEmailBox
            // 
            this.InfoEmailBox.Location = new System.Drawing.Point(13, 116);
            this.InfoEmailBox.Name = "InfoEmailBox";
            this.InfoEmailBox.ReadOnly = true;
            this.InfoEmailBox.Size = new System.Drawing.Size(245, 20);
            this.InfoEmailBox.TabIndex = 2;
            this.InfoEmailBox.TabStop = false;
            // 
            // LabelInfoName
            // 
            this.LabelInfoName.AutoSize = true;
            this.LabelInfoName.Location = new System.Drawing.Point(9, 37);
            this.LabelInfoName.Name = "LabelInfoName";
            this.LabelInfoName.Size = new System.Drawing.Size(35, 13);
            this.LabelInfoName.TabIndex = 3;
            this.LabelInfoName.Text = "Name";
            // 
            // LabelInfoEmail
            // 
            this.LabelInfoEmail.AutoSize = true;
            this.LabelInfoEmail.Location = new System.Drawing.Point(9, 100);
            this.LabelInfoEmail.Name = "LabelInfoEmail";
            this.LabelInfoEmail.Size = new System.Drawing.Size(32, 13);
            this.LabelInfoEmail.TabIndex = 4;
            this.LabelInfoEmail.Text = "Email";
            // 
            // InfoPasswordBox
            // 
            this.InfoPasswordBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InfoPasswordBox.Location = new System.Drawing.Point(12, 181);
            this.InfoPasswordBox.Name = "InfoPasswordBox";
            this.InfoPasswordBox.ReadOnly = true;
            this.InfoPasswordBox.Size = new System.Drawing.Size(246, 20);
            this.InfoPasswordBox.TabIndex = 5;
            this.InfoPasswordBox.TabStop = false;
            // 
            // LabelInfoPassword
            // 
            this.LabelInfoPassword.AutoSize = true;
            this.LabelInfoPassword.Location = new System.Drawing.Point(9, 165);
            this.LabelInfoPassword.Name = "LabelInfoPassword";
            this.LabelInfoPassword.Size = new System.Drawing.Size(53, 13);
            this.LabelInfoPassword.TabIndex = 6;
            this.LabelInfoPassword.Text = "Password";
            // 
            // InfoAgeBox
            // 
            this.InfoAgeBox.Location = new System.Drawing.Point(12, 254);
            this.InfoAgeBox.Name = "InfoAgeBox";
            this.InfoAgeBox.ReadOnly = true;
            this.InfoAgeBox.Size = new System.Drawing.Size(39, 20);
            this.InfoAgeBox.TabIndex = 7;
            this.InfoAgeBox.TabStop = false;
            // 
            // LabelInfoAge
            // 
            this.LabelInfoAge.AutoSize = true;
            this.LabelInfoAge.Location = new System.Drawing.Point(13, 235);
            this.LabelInfoAge.Name = "LabelInfoAge";
            this.LabelInfoAge.Size = new System.Drawing.Size(26, 13);
            this.LabelInfoAge.TabIndex = 8;
            this.LabelInfoAge.Text = "Age";
            // 
            // InfoRankBox
            // 
            this.InfoRankBox.Location = new System.Drawing.Point(12, 323);
            this.InfoRankBox.Name = "InfoRankBox";
            this.InfoRankBox.ReadOnly = true;
            this.InfoRankBox.Size = new System.Drawing.Size(39, 20);
            this.InfoRankBox.TabIndex = 9;
            this.InfoRankBox.TabStop = false;
            // 
            // LabelInfoRank
            // 
            this.LabelInfoRank.AutoSize = true;
            this.LabelInfoRank.Location = new System.Drawing.Point(12, 304);
            this.LabelInfoRank.Name = "LabelInfoRank";
            this.LabelInfoRank.Size = new System.Drawing.Size(33, 13);
            this.LabelInfoRank.TabIndex = 10;
            this.LabelInfoRank.Text = "Rank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Your deposits";
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
            this.unitDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.ProductGrid.DataSource = this.productBindingSource;
            this.ProductGrid.Location = new System.Drawing.Point(305, 181);
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.ReadOnly = true;
            this.ProductGrid.RowHeadersVisible = false;
            this.ProductGrid.Size = new System.Drawing.Size(389, 257);
            this.ProductGrid.TabIndex = 13;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sampleDataGridViewTextBoxColumn
            // 
            this.sampleDataGridViewTextBoxColumn.DataPropertyName = "Sample";
            this.sampleDataGridViewTextBoxColumn.HeaderText = "Sample";
            this.sampleDataGridViewTextBoxColumn.Name = "sampleDataGridViewTextBoxColumn";
            this.sampleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(LibraryPawnShop.Models.Product);
            // 
            // DateTimeBox
            // 
            this.DateTimeBox.Location = new System.Drawing.Point(371, 116);
            this.DateTimeBox.Name = "DateTimeBox";
            this.DateTimeBox.ReadOnly = true;
            this.DateTimeBox.Size = new System.Drawing.Size(137, 20);
            this.DateTimeBox.TabIndex = 14;
            this.DateTimeBox.TabStop = false;
            // 
            // DateTimeBuyOutBox
            // 
            this.DateTimeBuyOutBox.Location = new System.Drawing.Point(533, 116);
            this.DateTimeBuyOutBox.Name = "DateTimeBuyOutBox";
            this.DateTimeBuyOutBox.ReadOnly = true;
            this.DateTimeBuyOutBox.Size = new System.Drawing.Size(137, 20);
            this.DateTimeBuyOutBox.TabIndex = 15;
            this.DateTimeBuyOutBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "DateTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "DateTimeBuyOut";
            // 
            // ClientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTimeBuyOutBox);
            this.Controls.Add(this.DateTimeBox);
            this.Controls.Add(this.ProductGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepositComboBox);
            this.Controls.Add(this.LabelInfoRank);
            this.Controls.Add(this.InfoRankBox);
            this.Controls.Add(this.LabelInfoAge);
            this.Controls.Add(this.InfoAgeBox);
            this.Controls.Add(this.LabelInfoPassword);
            this.Controls.Add(this.InfoPasswordBox);
            this.Controls.Add(this.LabelInfoEmail);
            this.Controls.Add(this.LabelInfoName);
            this.Controls.Add(this.InfoEmailBox);
            this.Controls.Add(this.InfoNameBox);
            this.Name = "ClientInfoForm";
            this.Text = "ClientInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InfoNameBox;
        private System.Windows.Forms.TextBox InfoEmailBox;
        private System.Windows.Forms.Label LabelInfoName;
        private System.Windows.Forms.Label LabelInfoEmail;
        private System.Windows.Forms.TextBox InfoPasswordBox;
        private System.Windows.Forms.Label LabelInfoPassword;
        private System.Windows.Forms.TextBox InfoAgeBox;
        private System.Windows.Forms.Label LabelInfoAge;
        private System.Windows.Forms.TextBox InfoRankBox;
        private System.Windows.Forms.Label LabelInfoRank;
        private System.Windows.Forms.BindingSource depositBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductGrid;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox DateTimeBox;
        private System.Windows.Forms.TextBox DateTimeBuyOutBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DepositComboBox;
    }
}