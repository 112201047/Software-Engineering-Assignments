using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    public class ChatManager: IMessageListener
    {
        private readonly ICommunicator _communicator;
        public const string Id = "chat";
        public ChatManager(ICommunicator communicator)
        { 
            _communicator = communicator;
            communicator.Subscribe(Id, this);
        }
        public void OnMessageReceived(string message)
        {
            Console.WriteLine($"\nChatManager received:\n{message}");
        }
    }
}
