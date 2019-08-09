using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client.Lib
{
    
    class ClientHandler
    {
        private IPEndPoint serverIp { get; set; }
        private TcpClient client { get; set; }
        private NetworkStream networkStream { get; set;  }

        public ClientHandler(string ip, int port)
        {  
            serverIp = new IPEndPoint(IPAddress.Parse(ip), port);
        }

        public string request(string command)
        {
            command += "#<EOF>";

            client = new TcpClient();
            try
            {
                client.Connect(serverIp);
            }
            catch { return "connection_refused"; }
            


            networkStream = client.GetStream();

            byte[] bytesToWrite = Encoding.Unicode.GetBytes(command);
            string sBuffer = Encoding.Unicode.GetString(bytesToWrite);
            networkStream.Write(bytesToWrite, 0, bytesToWrite.Length);
            networkStream.Flush();

            byte[] bytesToRead = new byte[1024];
            string result = "";
            while (true)
            {

                int bytesRec = networkStream.Read(bytesToRead, 0, bytesToRead.Length);
                result += Encoding.Unicode.GetString(bytesToRead, 0, bytesRec);
                if (result.IndexOf("<EOF>") > -1)
                {
                    break;
                }
            }

            /*byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            networkStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
            string result =  Encoding.Unicode.GetString(bytesToRead);
            */
            networkStream.Close();
            client.Close();

            return result.Substring(0,result.Length-6);
        }
}
}
