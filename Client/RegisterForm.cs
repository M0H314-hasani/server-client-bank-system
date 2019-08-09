using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Dynamic;

namespace Client
{
    public partial class RegisterForm : Form
    {
        public dynamic user { get; set; }
        public RegisterForm()
        {
            InitializeComponent();
            user = new ExpandoObject();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            user.First_name = firstNameTextBox.Text;
            user.Last_name = lastNameTextBox.Text;
            user.National_id = nationalIdTextBox2.Text;
            user.Address = addressTextBox.Text;
            user.Phone = phoneTextBox.Text;
            user.Postal_code = postalCodeTextBox.Text;
            user.Email = emailTextBox.Text;
            Close();
        }

        
    }
}
