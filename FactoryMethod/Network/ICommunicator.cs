namespace Network
{
    public interface ICommunicator
    {
        public void SendMessage(string message, string ipAddress);
    }
}
