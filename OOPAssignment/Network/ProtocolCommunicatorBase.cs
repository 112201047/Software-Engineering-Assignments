namespace Network
{
    public abstract class ProtocolCommunicatorBase
    {
        public void OpenSocket()
        {
            // Implementation of opening the socket

            // Simulating opening the socket
            Console.WriteLine("Opening Socket....");
        }
        public void CloseSocket()
        {
            // Implementation of opening the socket

            // Simulating closing the socket
            Console.WriteLine("Closing Socket....");
        }
        public abstract void SetProtocol();
    }
}
