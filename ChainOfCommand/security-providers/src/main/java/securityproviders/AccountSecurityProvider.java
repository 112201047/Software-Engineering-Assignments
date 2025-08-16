package securityproviders;

public class AccountSecurityProvider implements ISecurityProvider {
    public AccountSecurityProvider() {
        // Constructor logic if needed
    }

    @Override
    public boolean scan() {
        // Simulate an account security scan
        System.out.println("Scanning account security...");
        return true; // Assume the scan is successful
    }

    @Override
    public String getName() {
        return "Account Security Provider";
    }
}
