package securityproviders;

public class AccountSecurityProvider implements ISecurityProvider {
    private ISecurityProvider nextSecurityProvider;

    public AccountSecurityProvider() {
        // Constructor logic if needed
    }


    @Override
    public void setNextSecurityProvider(ISecurityProvider securityProvider) {
        this.nextSecurityProvider = securityProvider;
    }

    @Override
    public boolean scan() {
        // Simulate an account security scan
        System.out.println("Initializing account security...");
        ISecurityProvider onlineAccountSecurity = new OnlineAccountSecurityProvider();
        setNextSecurityProvider(onlineAccountSecurity);
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
        return "Account Security Provider";
    }
}
