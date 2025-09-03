using Networking;


namespace Chat
{
    public delegate void ChatMessageReceived(string message);
    public class ChatManager: IMessageListener
    {
        public const string Id = "chat";
        public event ChatMessageReceived? OnChatMessageReceived;

        public ChatManager()
        {
            // Constructor logic if needed
        }
        public void OnMessageReceived(string message, string id)
        {
            OnChatMessageReceived?.Invoke(message);
        }
    }
}
