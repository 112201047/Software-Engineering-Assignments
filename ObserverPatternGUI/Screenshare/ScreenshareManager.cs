using Networking;

namespace Screenshare
{
    public delegate void ScreenshareMessageReceived(string message);
    public class ScreenshareManager : IMessageListener
    {
        private readonly ICommunicator _communicator;
        public const string Id = "screenshare";
        public event ScreenshareMessageReceived? OnScreenshareMessageReceived;

        public ScreenshareManager(ICommunicator communicator)
        {
            _communicator = communicator;
            communicator.Subscribe(Id, this);
        }

        public void OnMessageReceived(string message, string id)
        {
            OnScreenshareMessageReceived?.Invoke(message);
        }
    }
}
