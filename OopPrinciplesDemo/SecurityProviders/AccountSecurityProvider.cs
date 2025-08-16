using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProviders
{
    public class AccountSecurityProvider : ISecurityProvider
    {
        public AccountSecurityProvider()
        {
            // Constructor logic if needed
        }

        public virtual bool Scan()
        {
            // Simulate an account security scan
            Console.WriteLine("Scanning account security...");
            return true; // Assume the scan is successful
        }

        public virtual string GetName()
        {
            return "Account Security Provider";
        }
    }
}
