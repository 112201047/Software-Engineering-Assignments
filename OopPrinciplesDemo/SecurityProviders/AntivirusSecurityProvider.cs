namespace SecurityProviders
{
    public class AntivirusSecurityProvider : ISecurityProvider
    {
        public AntivirusSecurityProvider()
        {
            // Constructor logic if needed
        }

        public virtual bool Scan()
        {
            // Simulate a virus scan
            Console.WriteLine("Scanning for viruses...");
            return true; // Assume the scan is successful
        }

        public virtual string GetName()
        {
            return "Antivirus Security Provider";
        }
    }
}
