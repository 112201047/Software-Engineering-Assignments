package securityproviders;

public class DeviceSecurity implements ISecurityProvider {
    public DeviceSecurity() {
        // Constructor logic if needed
    }

    @Override
    public boolean scan() {
        // Simulate a device security scan
        System.out.println("Scanning device security...");
        return true; // Assume the scan is successful
    }

    @Override
    public String getName() {
        return "Device Security Provider";
    }
}
