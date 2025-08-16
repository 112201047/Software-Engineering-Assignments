namespace Network
{
    public class TcpCommunicator: ProtocolCommunicatorBase, ICommunicator
    {
        public TcpCommunicator()
        {
            // Constructor logic if needed
        }
        public void SendMessage(string message, string ipAddress)
        {
            // Implementation of sending a message over TCP

            // Simulating sending a message
            SetProtocol();
            OpenSocket();
            Console.WriteLine($"Sending message: '{message}' to IP Address: {ipAddress} over TCP.");
            CloseSocket();
        }

        public override void SetProtocol()
        {
            // Implementation of setting the protocol

            // Simulating setting the TCP protocol 
            Console.WriteLine("Setting TCP Protocol....");
        }

    }
}
