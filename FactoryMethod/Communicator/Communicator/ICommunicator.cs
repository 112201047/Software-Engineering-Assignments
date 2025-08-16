using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communicator
{
    public interface ICommunicator
    {
        void SendMessage(string message, string ipAddress);
        string GetCommunicatorName();
    }
}
