using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    public static class CommunicatorFactory
    {
        public static ICommunicator GetCommunicator(bool reliableRequired)
        {
            if (reliableRequired)
            {
                return new TcpCommunicator();
            }
            else
            {
                return new UdpCommunicator();
            }
        }
    }
}
