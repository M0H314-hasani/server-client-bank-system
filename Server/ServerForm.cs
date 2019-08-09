using System;
using System.Windows.Forms;
using Server.Lib;

namespace Server
{
    
    public partial class ServerForm : Form
    {
        private ServerHandler server;
        public ServerForm()
        {
            InitializeComponent();
        }

        private string mainServerController(string incomingRequest)
        {
            ApiHandler api =  new ApiHandler();

            string result = api.handle(incomingRequest);

            return result;
        }

        private void serveButton_Click(object sender, EventArgs e)
        {
            if (serveButton.Text == "Serve")
            {
                int port = int.Parse(portTextBox.Text);
                server = new ServerHandler(port, mainServerController);
                server.handle();

                serveButton.Text = "Stop";
            }
            else
            {
                server.stop();
                serveButton.Text = "Serve";
            }

        }
    }
}
