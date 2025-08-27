using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    public class ScreenshareManager: IMessageListener
    {
        private readonly ICommunicator _communicator;
        public const string Id = "screenShare";

        public ScreenshareManager(ICommunicator communicator)
        { 
            _communicator = communicator;
            communicator.Subscribe(Id, this);
        }

        public void OnMessageReceived(string message)
        {
            Console.WriteLine($"\nScreenshareManager received:\n{message}");
        }
    }
}
