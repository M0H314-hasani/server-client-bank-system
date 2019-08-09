using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Dynamic;
using Client.Lib;

namespace Client

{
    public partial class Client : Form
    {
        private ClientHandler client;
        public Client()
        {
            InitializeComponent();

            nationalIDtextBox.Enabled = false;
            registerButton.Enabled = false;
            checkUserProfileButton.Enabled = false;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

      private void connectToolStripMenuItem_Click(object sender, EventArgs e)
      {
            Option o = new Option();
            o.ShowDialog();

            client = new ClientHandler(o.get_IPAddress, o.get_port_destination);

            if(client.request("Test#test#test") != "connection_refused")
            {
                nationalIDtextBox.Enabled = true;
                registerButton.Enabled = true;
                checkUserProfileButton.Enabled = true;
            }
     
        }

        
        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm r = new RegisterForm();
            r.ShowDialog();

            string userJson = JsonConvert.SerializeObject(r.user);

            client.request("User#Register#" + userJson);         
        }
        
        private void checkUserProfileButton_Click(object sender, EventArgs e)
        {
            string result = client.request("User#CheckProfile#" + nationalIDtextBox.Text);
            if (result != "user_not_found")
            {
                UserProfileForm profile = new UserProfileForm(client, nationalIDtextBox.Text);
                profile.ShowDialog();
            } else
            {
                MessageBox.Show(result);
            }
        }
    }
}
