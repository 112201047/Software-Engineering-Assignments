package securityproviders;

public class OnlineAccountSecurityProvider extends AccountSecurityProvider implements ISecurityProvider {
    public OnlineAccountSecurityProvider() {
        // Constructor logic if needed
    }

    @Override
    public boolean scan() {
        // Note: Online account security scans may also involve checking local account security.

        // Simulate an online account security scan
        System.out.println("Scanning online account security...");
        boolean scanResult = true; // Assume the scan is successful

        // Call the base class scan method.
        boolean baseScanResult = super.scan();
        return baseScanResult && scanResult; // Combine results
    }

    @Override
    public String getName() {
        return "Online Account Security Provider";
    }
}
