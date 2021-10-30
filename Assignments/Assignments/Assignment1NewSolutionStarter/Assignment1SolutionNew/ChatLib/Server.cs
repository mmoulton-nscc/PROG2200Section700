using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ChatLib
{
    public class Server : NetworkingBase
    {
        TcpListener thisServer;
        NetworkStream thisStream;
        public void StartServer()
        {
            TcpListener server = null;
            // TcpListener server = new TcpListener(port);
            server = new TcpListener(IPAddress.Parse(Server.IPADDRESS), Server.PORT);

            thisServer = server;
            // Start listening for client requests.
            server.Start();
        }
        public override void Disconnect()
        {
            thisServer.Stop();
            thisStream.Close();
        }

        public override string GetMessage()
        {
            // Buffer for reading data
            Byte[] bytes = new Byte[256];
            String data = null;

            // Enter the listening loop.
            while (true)
            {
                Console.Write("Waiting for a connection... ");

                // Perform a blocking call to accept requests.
                // You could also use server.AcceptSocket() here.
                TcpClient client = thisServer.AcceptTcpClient();
                Console.WriteLine("Connected!");

                data = null;

                // Get a stream object for reading and writing
                NetworkStream stream = client.GetStream();
                thisStream = stream;
                int i;

                // Loop to receive all the data sent by the client.
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    // Translate data bytes to a ASCII string.
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                }
                return data;
            }
        }
    }
}
