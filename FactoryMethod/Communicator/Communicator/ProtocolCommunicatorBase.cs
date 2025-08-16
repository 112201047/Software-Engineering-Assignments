using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communicator
{
    public abstract class ProtocolCommunicatorBase
    {
        public string Protocol = "";
        public void OpenSocket()
        {
            Console.WriteLine("Opening socket...");
        }

        public void CloseSocket()
        {
            Console.WriteLine("Closing socket...");
        }

        public void HandShake()
        {
            Console.WriteLine("Performing handshake...");
        }

        public void SendData(string data, string ipAddress)
        {
            Console.WriteLine($"Sending data to {ipAddress} via {Protocol}: {data}");
        }
        abstract public void SetProtocol();
    }
}
