package securityproviders;

public class CompleteSecurity implements ISecurityProvider{
    private ISecurityProvider nextSecurityProvider;

    public CompleteSecurity(){
        // Constructor logic if needed
    }

    @Override
    public void setNextSecurityProvider(ISecurityProvider securityProvider) {
        this.nextSecurityProvider = securityProvider;
    }

    @Override
    public boolean scan() {
        // Simulate a device security scan
        System.out.println("Initializing complete security...");
        ISecurityProvider deviceSecurity = new DeviceSecurity();
        setNextSecurityProvider(deviceSecurity);
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
        return "Complete Security Provider";
    }
}

