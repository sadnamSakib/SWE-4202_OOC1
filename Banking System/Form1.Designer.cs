namespace Banking_System
{
    partial class Form1
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
            this.createAccountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createAccountContact = new System.Windows.Forms.TextBox();
            this.createAccountComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.transactionNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.transactionAccountNoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.transactionActionConboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.transactionAccountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.transactionActionButton = new System.Windows.Forms.Button();
            this.transactionAmountComboBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createAccountName
            // 
            this.createAccountName.Location = new System.Drawing.Point(144, 48);
            this.createAccountName.Name = "createAccountName";
            this.createAccountName.Size = new System.Drawing.Size(179, 22);
            this.createAccountName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contact No";
            // 
            // createAccountContact
            // 
            this.createAccountContact.Location = new System.Drawing.Point(144, 93);
            this.createAccountContact.Name = "createAccountContact";
            this.createAccountContact.Size = new System.Drawing.Size(179, 22);
            this.createAccountContact.TabIndex = 2;
            // 
            // createAccountComboBox
            // 
            this.createAccountComboBox.FormattingEnabled = true;
            this.createAccountComboBox.Items.AddRange(new object[] {
            "SAVINGS",
            "CURRENT",
            "LOAN"});
            this.createAccountComboBox.Location = new System.Drawing.Point(144, 138);
            this.createAccountComboBox.Name = "createAccountComboBox";
            this.createAccountComboBox.Size = new System.Drawing.Size(179, 24);
            this.createAccountComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Account Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 7;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(866, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(480, 468);
            this.listBox1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(570, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Account No";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(664, 44);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(179, 22);
            this.textBox5.TabIndex = 18;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(144, 200);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(179, 23);
            this.createAccountButton.TabIndex = 20;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(664, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Account Information";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(664, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Transaction History";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(-4, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(847, 10);
            this.label11.TabIndex = 26;
            this.label11.Text = "label11";
            // 
            // transactionNameTextBox
            // 
            this.transactionNameTextBox.Location = new System.Drawing.Point(128, 297);
            this.transactionNameTextBox.Name = "transactionNameTextBox";
            this.transactionNameTextBox.Size = new System.Drawing.Size(179, 22);
            this.transactionNameTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // transactionAccountNoTextBox
            // 
            this.transactionAccountNoTextBox.Location = new System.Drawing.Point(128, 333);
            this.transactionAccountNoTextBox.Name = "transactionAccountNoTextBox";
            this.transactionAccountNoTextBox.Size = new System.Drawing.Size(179, 22);
            this.transactionAccountNoTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Account No";
            // 
            // transactionActionConboBox
            // 
            this.transactionActionConboBox.FormattingEnabled = true;
            this.transactionActionConboBox.Items.AddRange(new object[] {
            "WITHDRAW",
            "DEPOSIT",
            "LOAN"});
            this.transactionActionConboBox.Location = new System.Drawing.Point(128, 414);
            this.transactionActionConboBox.Name = "transactionActionConboBox";
            this.transactionActionConboBox.Size = new System.Drawing.Size(179, 24);
            this.transactionActionConboBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Account Type";
            // 
            // transactionAccountTypeComboBox
            // 
            this.transactionAccountTypeComboBox.FormattingEnabled = true;
            this.transactionAccountTypeComboBox.Items.AddRange(new object[] {
            "SAVINGS",
            "CURRENT",
            "LOAN"});
            this.transactionAccountTypeComboBox.Location = new System.Drawing.Point(130, 374);
            this.transactionAccountTypeComboBox.Name = "transactionAccountTypeComboBox";
            this.transactionAccountTypeComboBox.Size = new System.Drawing.Size(179, 24);
            this.transactionAccountTypeComboBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Action";
            // 
            // transactionActionButton
            // 
            this.transactionActionButton.Location = new System.Drawing.Point(128, 498);
            this.transactionActionButton.Name = "transactionActionButton";
            this.transactionActionButton.Size = new System.Drawing.Size(181, 23);
            this.transactionActionButton.TabIndex = 21;
            this.transactionActionButton.Text = "Make Transaction";
            this.transactionActionButton.UseVisualStyleBackColor = true;
            this.transactionActionButton.Click += new System.EventHandler(this.transactionActionButton_Click);
            // 
            // transactionAmountComboBox
            // 
            this.transactionAmountComboBox.Location = new System.Drawing.Point(128, 457);
            this.transactionAmountComboBox.Name = "transactionAmountComboBox";
            this.transactionAmountComboBox.Size = new System.Drawing.Size(179, 22);
            this.transactionAmountComboBox.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 526);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.transactionAmountComboBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.transactionActionButton);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.transactionAccountTypeComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.transactionActionConboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.transactionAccountNoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.transactionNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createAccountComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createAccountContact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createAccountName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox createAccountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox createAccountContact;
        private System.Windows.Forms.ComboBox createAccountComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox transactionNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox transactionAccountNoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox transactionActionConboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox transactionAccountTypeComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button transactionActionButton;
        private System.Windows.Forms.TextBox transactionAmountComboBox;
        private System.Windows.Forms.Label label10;
    }
}

