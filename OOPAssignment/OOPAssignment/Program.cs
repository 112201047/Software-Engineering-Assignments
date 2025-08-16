using Network;

namespace Controller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICommunicator tcpCommunicator = new TcpCommunicator();
            tcpCommunicator.SendMessage("Test message for OOP Model", "127.0.0.1");

            ICommunicator udpCommunicator = new UdpCommunicator();
            udpCommunicator.SendMessage("Test message for OOP Model", "127.0.0.2");

            ICommunicator rpcCommunicator = new RemoteProcedureCallCommunicator();
            rpcCommunicator.SendMessage("Test message for OOP Model", "127.0.0.3");
        }
    }
}
