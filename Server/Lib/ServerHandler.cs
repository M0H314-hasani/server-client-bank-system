using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server.Lib
{
    class ServerHandler
    {
        public TcpListener mainListener { get; }
        private int port;
        private Thread mainThread;
        public Callback callback { set; get; }
        public ServerHandler(int port, Callback callback)
        {
            mainListener = new TcpListener(port);

            mainThread = new Thread(new ThreadStart(_mainThread));

            this.callback = callback;           
        }

        public delegate string Callback(string payload);
        public void handle()
        {
            mainListener.Start();
            mainThread.Start();
        }

        private void _mainThread()
        {
            try
            {
                while (true)
                {
                    Socket mySocket = mainListener.AcceptSocket();
                    if (!mySocket.Connected)
                        continue;

                    byte[] buffer = new byte[1024];
                    string sBuffer = "";
                    while (true)
                    {

                        int bytesRec = mySocket.Receive(buffer);
                        sBuffer += Encoding.Unicode.GetString(buffer, 0, bytesRec);
                        if (sBuffer.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }

                    string sData = callback(sBuffer.ToString());
                    sData += "#<EOF>";

                    byte[] bSendData = Encoding.Unicode.GetBytes(sData);
                    int numberOfBytes = mySocket.Send(bSendData, bSendData.Length, 0);

                    mySocket.Close();
                }
            } catch (Exception e) { Console.Write(e.ToString()); }
        }

        public void stop()
        {
            mainListener.Stop();
        }

    }
}
