using Networking;

namespace Screenshare
{
    public delegate void ScreenshareMessageReceived(string message);
    public class ScreenshareManager : IMessageListener
    {
        public const string Id = "screenshare";
        public event ScreenshareMessageReceived? OnScreenshareMessageReceived;

        public ScreenshareManager()
        {
            // Constructor logic if needed
        }

        public void OnMessageReceived(string message, string id)
        {
            OnScreenshareMessageReceived?.Invoke(message);
        }
    }
}
