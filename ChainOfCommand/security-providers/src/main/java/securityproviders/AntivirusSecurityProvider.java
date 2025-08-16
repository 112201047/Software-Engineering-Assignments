package securityproviders;

public class AntivirusSecurityProvider implements ISecurityProvider {
    private ISecurityProvider nextSecurityProvider;

    public AntivirusSecurityProvider() {
        // Constructor logic if needed
    }

    @Override
    public void setNextSecurityProvider(ISecurityProvider securityProvider) {
        this.nextSecurityProvider = securityProvider;
    }

    @Override
    public boolean scan() {
        // Simulate a virus scan
        System.out.println("Initializing antivirus security...");
        ISecurityProvider accountSecurity = new AccountSecurityProvider();
        setNextSecurityProvider(accountSecurity);
        System.out.println("Using " + nextSecurityProvider.getName());
        if (nextSecurityProvider.scan()) {
            System.out.println(nextSecurityProvider.getName() + " scan completed successfully.\n");
        } else {
            System.out.println(nextSecurityProvider.getName() + " scan failed.\n");
        }
        return true; // Assume the scan is successful
    }

    @Override
    public String getName() {
        return "Antivirus Security Provider";
    }
}
