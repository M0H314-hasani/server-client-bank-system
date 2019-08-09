namespace Client
{
    partial class UserProfileForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bankAccountsListView = new System.Windows.Forms.ListView();
            this.accountsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newAccountButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nationalIdTextBox = new System.Windows.Forms.TextBox();
            this.nationalIdLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showTransactionsButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawalButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bankAccountsListView);
            this.flowLayoutPanel1.Controls.Add(this.newAccountButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(383, 702);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bankAccountsListView
            // 
            this.bankAccountsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.accountsColumnHeader});
            this.bankAccountsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankAccountsListView.Location = new System.Drawing.Point(3, 3);
            this.bankAccountsListView.Name = "bankAccountsListView";
            this.bankAccountsListView.Size = new System.Drawing.Size(380, 630);
            this.bankAccountsListView.TabIndex = 0;
            this.bankAccountsListView.UseCompatibleStateImageBehavior = false;
            this.bankAccountsListView.View = System.Windows.Forms.View.Details;
            this.bankAccountsListView.SelectedIndexChanged += new System.EventHandler(this.bankAccountsListView_SelectedIndexChanged);
            // 
            // accountsColumnHeader
            // 
            this.accountsColumnHeader.Text = "";
            this.accountsColumnHeader.Width = 375;
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(3, 639);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(380, 54);
            this.newAccountButton.TabIndex = 1;
            this.newAccountButton.Text = "New Account";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.avatarPictureBox);
            this.panel1.Controls.Add(this.updateUserButton);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.postalCodeTextBox);
            this.panel1.Controls.Add(this.postalCodeLabel);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(this.phoneLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.addressLabel);
            this.panel1.Controls.Add(this.nationalIdTextBox);
            this.panel1.Controls.Add(this.nationalIdLabel);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.lastNameLabel);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(this.firstNameLabel);
            this.panel1.Location = new System.Drawing.Point(401, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 386);
            this.panel1.TabIndex = 76;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Location = new System.Drawing.Point(430, 21);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(501, 273);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPictureBox.TabIndex = 91;
            this.avatarPictureBox.TabStop = false;
            this.avatarPictureBox.DoubleClick += new System.EventHandler(this.avatarPictureBox_DoubleClick);
            // 
            // updateUserButton
            // 
            this.updateUserButton.Location = new System.Drawing.Point(3, 318);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(951, 65);
            this.updateUserButton.TabIndex = 90;
            this.updateUserButton.Text = "Update";
            this.updateUserButton.UseVisualStyleBackColor = true;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(95, 274);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(308, 22);
            this.emailTextBox.TabIndex = 89;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(43, 277);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 88;
            this.emailLabel.Text = "Email";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(95, 231);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(308, 22);
            this.postalCodeTextBox.TabIndex = 87;
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Location = new System.Drawing.Point(8, 234);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(84, 17);
            this.postalCodeLabel.TabIndex = 86;
            this.postalCodeLabel.Text = "Postal Code";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(95, 188);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(308, 22);
            this.phoneTextBox.TabIndex = 85;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(43, 191);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(49, 17);
            this.phoneLabel.TabIndex = 84;
            this.phoneLabel.Text = "Phone";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(95, 146);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(308, 22);
            this.addressTextBox.TabIndex = 83;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(29, 149);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 82;
            this.addressLabel.Text = "Address";
            // 
            // nationalIdTextBox
            // 
            this.nationalIdTextBox.Location = new System.Drawing.Point(97, 103);
            this.nationalIdTextBox.Name = "nationalIdTextBox";
            this.nationalIdTextBox.Size = new System.Drawing.Size(308, 22);
            this.nationalIdTextBox.TabIndex = 81;
            // 
            // nationalIdLabel
            // 
            this.nationalIdLabel.AutoSize = true;
            this.nationalIdLabel.Location = new System.Drawing.Point(14, 106);
            this.nationalIdLabel.Name = "nationalIdLabel";
            this.nationalIdLabel.Size = new System.Drawing.Size(75, 17);
            this.nationalIdLabel.TabIndex = 80;
            this.nationalIdLabel.Text = "National Id";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(95, 60);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(308, 22);
            this.lastNameTextBox.TabIndex = 79;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 63);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 78;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(95, 18);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(308, 22);
            this.firstNameTextBox.TabIndex = 77;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(13, 21);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 76;
            this.firstNameLabel.Text = "First Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.showTransactionsButton);
            this.panel2.Controls.Add(this.depositButton);
            this.panel2.Controls.Add(this.withdrawalButton);
            this.panel2.Controls.Add(this.amountTextBox);
            this.panel2.Controls.Add(this.accountNumberLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.balanceLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(404, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 307);
            this.panel2.TabIndex = 77;
            // 
            // showTransactionsButton
            // 
            this.showTransactionsButton.Location = new System.Drawing.Point(470, 186);
            this.showTransactionsButton.Name = "showTransactionsButton";
            this.showTransactionsButton.Size = new System.Drawing.Size(481, 118);
            this.showTransactionsButton.TabIndex = 7;
            this.showTransactionsButton.Text = "Transactions";
            this.showTransactionsButton.UseVisualStyleBackColor = true;
            this.showTransactionsButton.Click += new System.EventHandler(this.showTransactionsButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(251, 241);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(213, 63);
            this.depositButton.TabIndex = 6;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawalButton
            // 
            this.withdrawalButton.Location = new System.Drawing.Point(28, 241);
            this.withdrawalButton.Name = "withdrawalButton";
            this.withdrawalButton.Size = new System.Drawing.Size(217, 63);
            this.withdrawalButton.TabIndex = 5;
            this.withdrawalButton.Text = "Withdrawal";
            this.withdrawalButton.UseVisualStyleBackColor = true;
            this.withdrawalButton.Click += new System.EventHandler(this.withdrawalButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.Location = new System.Drawing.Point(29, 186);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(435, 49);
            this.amountTextBox.TabIndex = 4;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.accountNumberLabel.Location = new System.Drawing.Point(377, 32);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(62, 44);
            this.accountNumberLabel.TabIndex = 3;
            this.accountNumberLabel.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.balanceLabel.Location = new System.Drawing.Point(377, 121);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(62, 44);
            this.balanceLabel.TabIndex = 1;
            this.balanceLabel.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number:";
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 726);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UserProfileForm";
            this.Text = "UserProfileForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView bankAccountsListView;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox nationalIdTextBox;
        private System.Windows.Forms.Label nationalIdLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showTransactionsButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawalButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ColumnHeader accountsColumnHeader;
        private System.Windows.Forms.PictureBox avatarPictureBox;
    }
}