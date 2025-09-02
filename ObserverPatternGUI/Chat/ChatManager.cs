using Networking;


namespace Chat
{
    public delegate void ChatMessageReceived(string message);
    public class ChatManager: IMessageListener
    {
        private readonly ICommunicator _communicator;
        public const string Id = "chat";
        public event ChatMessageReceived? OnChatMessageReceived;

        public ChatManager(ICommunicator communicator)
        {
            _communicator = communicator;
            communicator.Subscribe(Id, this);
        }
        public void OnMessageReceived(string message, string id)
        {
            OnChatMessageReceived?.Invoke(message);
        }
    }
}
