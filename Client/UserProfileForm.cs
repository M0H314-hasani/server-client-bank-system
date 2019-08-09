using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using Client.Lib;
using Newtonsoft.Json;
using System.Dynamic;
using System.Collections;
using System.IO;

namespace Client
{
    public partial class UserProfileForm : Form
    {
        ClientHandler client;
        dynamic user;
        dynamic[] bankAccounts;
        string national_id;
        dynamic selectedBankAccount;
        int selectedBankAccountListViewIndex;
        public UserProfileForm(object obj, string national_id)
        {
            ClientHandler client = obj as ClientHandler;
            InitializeComponent();
            this.client = client;
            this.national_id = national_id;
            init();
        }

        private void init()
        {       
            string result = client.request("User#CheckProfile#" + national_id);

            user = JsonConvert.DeserializeObject<ExpandoObject>(result);

            firstNameTextBox.Text = user.First_name;
            lastNameTextBox.Text = user.Last_name;
            nationalIdTextBox.Text = user.National_id;
            addressTextBox.Text = user.Address;
            phoneTextBox.Text = user.Phone;
            postalCodeTextBox.Text = user.Postal_code;
            emailTextBox.Text = user.Email;

            if (user.Avatar != null)
            {
                var pic = Convert.FromBase64String(user.Avatar);

                using (MemoryStream ms = new MemoryStream(pic))
                {
                    avatarPictureBox.Image = Image.FromStream(ms);
                }
            }
            getAccounts();
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            user.First_name = firstNameTextBox.Text;
            user.Last_name = lastNameTextBox.Text;
            user.National_id = nationalIdTextBox.Text;
            user.Address = addressTextBox.Text;
            user.Phone = phoneTextBox.Text;
            user.Postal_code = postalCodeTextBox.Text;
            user.Email = emailTextBox.Text;

            string userJsonString = JsonConvert.SerializeObject(user);

            client.request("User#UpdateProfile#" + user.Id + "#" + userJsonString);
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            client.request("BankAccount#createAccount#" + user.Id);
            getAccounts();
        }

        private void bankAccountsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = bankAccountsListView.SelectedItems[0].Text;
                for(int i=0; i < bankAccounts.Length; i++)
                {
                    if(bankAccounts[i].Account_number == selectedItem)
                    {
                        selectedBankAccount = bankAccounts[i];
                        selectedBankAccountListViewIndex = i;
                        accountNumberLabel.Text = bankAccounts[i].Account_number;
                        balanceLabel.Text = bankAccounts[i].Balance.ToString();
                        
                        break;
                    }
                }
            } catch (Exception error) { }
        }

        private void withdrawalButton_Click(object sender, EventArgs e)
        {
            if (selectedBankAccount.Balance - int.Parse(amountTextBox.Text) >= 0)
            {
                client.request("BankAccount#withdrawal#" + selectedBankAccount.Id + "#" + amountTextBox.Text);
                getAccounts();

                bankAccountsListView.FocusedItem = bankAccountsListView.Items[0];
                bankAccountsListView.Items[selectedBankAccountListViewIndex].Selected = true;
                bankAccountsListView.Select();
                bankAccountsListView.EnsureVisible(selectedBankAccountListViewIndex);
            }
            else MessageBox.Show("Balance couldn't be less than 0");

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            client.request("BankAccount#deposit#" + selectedBankAccount.Id + "#" + amountTextBox.Text);
            getAccounts();

            bankAccountsListView.FocusedItem = bankAccountsListView.Items[0];
            bankAccountsListView.Items[selectedBankAccountListViewIndex].Selected = true;
            bankAccountsListView.Select();
            bankAccountsListView.EnsureVisible(selectedBankAccountListViewIndex);
        }

        private void getAccounts()
        {
            string result = client.request("BankAccount#getBankAccountsByUserId#" + user.Id );

            bankAccounts = JsonConvert.DeserializeObject<ExpandoObject[]>(result);

            ArrayList list = new ArrayList();
            bankAccountsListView.Items.Clear();
            foreach (dynamic bankAccount in bankAccounts)
                bankAccountsListView.Items.Add(bankAccount.Account_number);
        }

        private void showTransactionsButton_Click(object sender, EventArgs e)
        {
            string result = client.request("Bill#getBillsByBankAccountId#" + selectedBankAccount.Id);

            dynamic[] transactions = JsonConvert.DeserializeObject<ExpandoObject[]>(result);

            TransactionsForm transactionsForm = new TransactionsForm(transactions);
            transactionsForm.ShowDialog();
        }

        private void avatarPictureBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.jpeg|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string base64String;
                using (Image image = Image.FromFile(openFileDialog.FileName))
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        byte[] imageBytes = m.ToArray();

                        // Convert byte[] to Base64 String
                        base64String = Convert.ToBase64String(imageBytes);
                        
                    }
                }

                user.Avatar = base64String;
                
                var pic = Convert.FromBase64String(base64String);

                using (MemoryStream ms = new MemoryStream(pic))
                {
                    avatarPictureBox.Image = Image.FromStream(ms);
                }
                
            }
                
        }
    }
}
