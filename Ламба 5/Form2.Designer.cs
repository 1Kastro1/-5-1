namespace Ламба_5
{
    partial class Form2
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
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label postal_CodeLabel;
            System.Windows.Forms.Label company_NameLabel;
            System.Windows.Forms.Label iDLabel;
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.postal_CodeTextBox = new System.Windows.Forms.TextBox();
            this.company_NameTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            cityLabel = new System.Windows.Forms.Label();
            postal_CodeLabel = new System.Windows.Forms.Label();
            company_NameLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(99, 137);
            cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(53, 13);
            cityLabel.TabIndex = 15;
            cityLabel.Text = "UnitPrice:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(157, 130);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(76, 20);
            this.cityTextBox.TabIndex = 16;
            // 
            // postal_CodeLabel
            // 
            postal_CodeLabel.AutoSize = true;
            postal_CodeLabel.Location = new System.Drawing.Point(68, 110);
            postal_CodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            postal_CodeLabel.Name = "postal_CodeLabel";
            postal_CodeLabel.Size = new System.Drawing.Size(84, 13);
            postal_CodeLabel.TabIndex = 13;
            postal_CodeLabel.Text = "QuantityPerUnit:";
            // 
            // postal_CodeTextBox
            // 
            this.postal_CodeTextBox.Location = new System.Drawing.Point(157, 107);
            this.postal_CodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.postal_CodeTextBox.Name = "postal_CodeTextBox";
            this.postal_CodeTextBox.Size = new System.Drawing.Size(76, 20);
            this.postal_CodeTextBox.TabIndex = 14;
            // 
            // company_NameLabel
            // 
            company_NameLabel.AutoSize = true;
            company_NameLabel.Location = new System.Drawing.Point(77, 87);
            company_NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            company_NameLabel.Name = "company_NameLabel";
            company_NameLabel.Size = new System.Drawing.Size(75, 13);
            company_NameLabel.TabIndex = 11;
            company_NameLabel.Text = "ProductName:";
            // 
            // company_NameTextBox
            // 
            this.company_NameTextBox.Location = new System.Drawing.Point(157, 84);
            this.company_NameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.company_NameTextBox.Name = "company_NameTextBox";
            this.company_NameTextBox.Size = new System.Drawing.Size(76, 20);
            this.company_NameTextBox.TabIndex = 12;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(94, 65);
            iDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(58, 13);
            iDLabel.TabIndex = 9;
            iDLabel.Text = "ProductID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.Location = new System.Drawing.Point(157, 62);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(76, 20);
            this.iDTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 352);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(postal_CodeLabel);
            this.Controls.Add(this.postal_CodeTextBox);
            this.Controls.Add(company_NameLabel);
            this.Controls.Add(this.company_NameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox postal_CodeTextBox;
        private System.Windows.Forms.TextBox company_NameTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}