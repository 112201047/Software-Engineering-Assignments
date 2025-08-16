using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communicator
{
    public class UdpCommunicator : ProtocolCommunicatorBase, ICommunicator
    {
        public UdpCommunicator()
        {
            // Constructor logic
        }

        public override void SetProtocol()
        {
            Protocol = "UDP";
        }

        public void SendMessage(string message, string ipAddress)
        {
            OpenSocket();
            SetProtocol();
            HandShake();
            SendData(message, ipAddress);
            CloseSocket();
        }

        public string GetCommunicatorName()
        {
            return "UDP-Communicator";
        }
    }
}
