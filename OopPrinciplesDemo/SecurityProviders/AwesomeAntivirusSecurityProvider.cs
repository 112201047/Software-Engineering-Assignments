using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProviders
{
    public class AwesomeAntivirusSecurityProvider: AntivirusSecurityProvider, ISecurityProvider
    {
        public AwesomeAntivirusSecurityProvider()
        {
            // Constructor logic if needed
        }
        public override bool Scan() 
        {
            // Simulate a virus scan
            Console.WriteLine("Scanning for viruses. New awesome version...");
            return true; // Assume the scan is successful
        }

        public override string GetName() 
        {
            return "Awesome Antivirus Security Provider";
        }
    }
}
