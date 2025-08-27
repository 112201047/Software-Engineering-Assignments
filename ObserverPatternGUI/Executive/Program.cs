using Networking;

namespace Executive
{
    public class Listener: IMessageListener
    {
        private readonly ICommunicator _communicator;
        public const string Id = "test";
        public Listener(ICommunicator communicator)
        {
            _communicator = communicator;
            communicator.Subscribe(Id, this);
        }
        public void OnMessageReceived(string message)
        {
            Console.WriteLine($"\nMessage received:\n{message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ICommunicator communicator = new Communicator();
            communicator.SendMessage("Test Message", "test");
            communicator.SendMessage("Chat Messages", "chat");
            communicator.SendMessage("Screen Share Messages", "screenShare");
            Console.WriteLine("Test Messages sent successfully.\n"); 

            IMessageListener testListener = new Listener(communicator);
            Console.WriteLine("Test listener subscribed. Waiting for messages...\n");

            IMessageListener chatListener = new ChatManager(communicator);
            Console.WriteLine("Chat listener subscribed. Waiting for messages...\n");

            IMessageListener screenShareListener = new ScreenshareManager(communicator);
            Console.WriteLine("Screen Share listener subscribed. Waiting for messages...\n");

            Console.WriteLine("Press any key to exit.....");
            Console.ReadKey();
        }
    }
}
