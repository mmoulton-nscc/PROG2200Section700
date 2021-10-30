using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ChatLib
{
    public class Client : NetworkingBase
    {
        TcpClient thisClient;
        NetworkStream thisStream;

        public void StartTcpClient()
        {
            // Create a TcpClient.
            // Note, for this client to work you need to have a TcpServer
            // connected to the same address as specified by the server, port
            // combination.
            TcpClient client = new TcpClient(Client.IPADDRESS, Client.PORT);
            thisClient = client;

            // Get a client stream for reading and writing.
            //  Stream stream = client.GetStream();

            NetworkStream stream = client.GetStream();
            thisStream = stream;
        }

        public override void Disconnect()
        {
            thisStream.Close();
            thisClient.Close();
        }

        public override string GetMessage()
        {
            // Buffer to store the response bytes.
            Byte[] data = new Byte[256];

            // String to store the response ASCII representation.
            String responseData = String.Empty;

            // Read the first batch of the TcpServer response bytes.
            Int32 bytes = thisStream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            return responseData;
        }
    }
}
