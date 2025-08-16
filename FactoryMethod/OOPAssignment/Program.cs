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

            // Using the factory to get a communicator
            ICommunicator reliableCommunicator = CommunicatorFactory.GetCommunicator(true);
            reliableCommunicator.SendMessage("Sending reliable message for OOP Model", "127.0.0.4");

            ICommunicator unreliableCommunicator = CommunicatorFactory.GetCommunicator(false); 
            unreliableCommunicator.SendMessage("Sending unreliable message for OOP Model", "127.0.0.5");
        }
    }
}
