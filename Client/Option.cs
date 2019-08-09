using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        int port = 0, port_dest = 0;
        string ip_dest = "";
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_IPDestination.Text != "" && txt_PortDest.Text != "")
            {
                port_dest = Int32.Parse(txt_PortDest.Text);
                ip_dest = txt_IPDestination.Text;
                
                Close();
            }
            else
                MessageBox.Show("Fill all of them.");
        }
        

        public string get_IPAddress
        {
            get
            {
                return ip_dest;
            }
        }
        public int get_port_destination
        {
            get
            {
                return port_dest;
            }
        }
   
    }
}
