using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communicator
{
    public class RpcCommunicator : ICommunicator
    {
        public string Protocol = "RPC";
        public RpcCommunicator() 
        {
            // Constructor logic
        }

        public void SendMessage(string message, string ipAddress)
        {
            RpcFunction1();
            SendData(message, ipAddress);
            RpcFunction2();
        }

        private void RpcFunction1()
        {
            Console.WriteLine("RPC Specific Function 1...");
        }

        private void RpcFunction2()
        {
            Console.WriteLine("RPC Specific Function 2...");
        }

        public void SendData(string data, string ipAddress)
        {
            Console.WriteLine($"Sending data to {ipAddress} via {Protocol}: {data}");
        }

        public string GetCommunicatorName()
        {
            return "RPC-Communicator";
        }
    }
}
