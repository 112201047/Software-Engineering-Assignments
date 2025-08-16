using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProviders
{
    public class ExtendedAntivirusSecurityProvider : AntivirusSecurityProvider, ISecurityProvider
    {
        public ExtendedAntivirusSecurityProvider() 
        { 
            // Empty logic for constructor
        }

        public override bool Scan()
        {
            // Simulate Extended Antivirus Scan
            Console.WriteLine("Extended scan for viruses...");
            bool scanResult = true; // Assuming scan to be successful

            // Calling the base class scan method.
            bool baseScanResult = base.Scan();
            return baseScanResult && scanResult; // Combined scan results
        }

        public override string GetName()
        {
            return "Extended Antivirus Security Provider";
        }

    }
}
