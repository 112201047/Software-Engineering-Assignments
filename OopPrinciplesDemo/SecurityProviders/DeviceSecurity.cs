using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProviders
{
    public class DeviceSecurity : ISecurityProvider
    {
        public DeviceSecurity()
        {
            // Constructor logic if needed
        }

        public bool Scan()
        {
            // Simulate a device security scan
            Console.WriteLine("Scanning device security...");
            return true; // Assume the scan is successful
        }

        public string GetName()
        {
            return "Device Security Provider";
        }
    }
}
