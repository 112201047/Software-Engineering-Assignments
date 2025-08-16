namespace Network
{
    public class UdpCommunicator: ProtocolCommunicatorBase, ICommunicator
    {
        public UdpCommunicator()
        {
            // Constructor logic if needed
        }
        public void SendMessage(string message, string ipAddress)
        {
            // Implementation of sending a message over UDP

            // Simulating sending a message
            SetProtocol();
            OpenSocket();
            Console.WriteLine($"Sending message: '{message}' to IP Address: {ipAddress} over UDP.");
            CloseSocket();
        }
        public override void SetProtocol()
        {
            // Implementation of setting the protocol

            // Simulating setting the UDP protocol 
            Console.WriteLine("Setting UDP Protocol....");
        }
    }
}
