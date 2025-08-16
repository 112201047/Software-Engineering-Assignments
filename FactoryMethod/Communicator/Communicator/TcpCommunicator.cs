namespace Communicator
{
    public class TcpCommunicator : ProtocolCommunicatorBase, ICommunicator
    {
        public TcpCommunicator()
        {
            // Constructor logic
        }

        public override void SetProtocol()
        {
            Protocol = "TCP";
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
            return "TCP-Communicator";
        }
    }
}
