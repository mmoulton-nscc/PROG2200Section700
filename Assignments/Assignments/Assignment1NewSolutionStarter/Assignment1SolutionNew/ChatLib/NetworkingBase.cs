using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ChatLib
{
    public abstract class NetworkingBase
    {
        public const Int32 PORT = 5555;
        public const string IPADDRESS = "127.0.0.1";

        public abstract String GetMessage();
        public abstract void Disconnect();
    }
}
