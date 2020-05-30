namespace AdminApp
{
    partial class LoanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanForm));
            this.AddItem = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.WeightField = new System.Windows.Forms.NumericUpDown();
            this.SilverComboBox = new System.Windows.Forms.ComboBox();
            this.GoldComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SampleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeightField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddItem
            // 
            this.AddItem.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddItem.Location = new System.Drawing.Point(37, 270);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(75, 23);
            this.AddItem.TabIndex = 0;
            this.AddItem.Text = "Add item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameBox
            // 
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Location = new System.Drawing.Point(38, 44);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 1;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "gold",
            "silver"});
            this.TypeComboBox.Location = new System.Drawing.Point(38, 100);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeComboBox.TabIndex = 2;
            this.TypeComboBox.TextChanged += new System.EventHandler(this.TypeComboBox_TextChanged);
            // 
            // WeightField
            // 
            this.WeightField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightField.DecimalPlaces = 1;
            this.WeightField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.WeightField.InterceptArrowKeys = false;
            this.WeightField.Location = new System.Drawing.Point(38, 150);
            this.WeightField.Name = "WeightField";
            this.WeightField.Size = new System.Drawing.Size(120, 20);
            this.WeightField.TabIndex = 4;
            // 
            // SilverComboBox
            // 
            this.SilverComboBox.FormattingEnabled = true;
            this.SilverComboBox.Items.AddRange(new object[] {
            "800",
            "830",
            "875",
            "925",
            "960",
            "999"});
            this.SilverComboBox.Location = new System.Drawing.Point(37, 243);
            this.SilverComboBox.Name = "SilverComboBox";
            this.SilverComboBox.Size = new System.Drawing.Size(121, 21);
            this.SilverComboBox.TabIndex = 5;
            // 
            // GoldComboBox
            // 
            this.GoldComboBox.FormattingEnabled = true;
            this.GoldComboBox.Items.AddRange(new object[] {
            "375",
            "500",
            "585",
            "750",
            "916",
            "958",
            "999"});
            this.GoldComboBox.Location = new System.Drawing.Point(37, 216);
            this.GoldComboBox.Name = "GoldComboBox";
            this.GoldComboBox.Size = new System.Drawing.Size(121, 21);
            this.GoldComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "g";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Weight";
            // 
            // SampleLabel
            // 
            this.SampleLabel.AutoSize = true;
            this.SampleLabel.Location = new System.Drawing.Point(35, 200);
            this.SampleLabel.Name = "SampleLabel";
            this.SampleLabel.Size = new System.Drawing.Size(42, 13);
            this.SampleLabel.TabIndex = 11;
            this.SampleLabel.Text = "Sample";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Click below to choose image";
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 317);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SampleLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoldComboBox);
            this.Controls.Add(this.SilverComboBox);
            this.Controls.Add(this.WeightField);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AddItem);
            this.Name = "LoanForm";
            this.Text = "LoanForm";
            ((System.ComponentModel.ISupportInitialize)(this.WeightField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.NumericUpDown WeightField;
        private System.Windows.Forms.ComboBox SilverComboBox;
        private System.Windows.Forms.ComboBox GoldComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SampleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
    }
}