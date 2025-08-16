using SecurityProviders;

namespace Controller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the various security provider instances.
            ISecurityProvider deviceSecurity = new DeviceSecurity();
            ISecurityProvider onlineAccountSecurity = new OnlineAccountSecurityProvider();
            ISecurityProvider accountSecurity = new AccountSecurityProvider();
            ISecurityProvider antivirusSecurity = new AntivirusSecurityProvider();
            ISecurityProvider awesomeAntivirusSecurity = new AwesomeAntivirusSecurityProvider();

            // Create a list of security providers.
            List<ISecurityProvider> securityProviders = new List<ISecurityProvider>();
            securityProviders.Add(deviceSecurity);
            securityProviders.Add(onlineAccountSecurity);
            securityProviders.Add(accountSecurity);
            securityProviders.Add(antivirusSecurity);
            securityProviders.Add(awesomeAntivirusSecurity);

            // Iterate through each security provider and perform a scan.
            foreach (var provider in securityProviders)
            {
                Console.WriteLine($"Using {provider.GetName()}");
                if (provider.Scan())
                {
                    Console.WriteLine($"{provider.GetName()} scan completed successfully.\n");
                }
                else
                {
                    Console.WriteLine($"{provider.GetName()} scan failed.\n");
                }
            }
        }
    }
}
