package securityproviders;

public class AntivirusSecurityProvider implements ISecurityProvider {
    public AntivirusSecurityProvider() {
        // Constructor logic if needed
    }

    @Override
    public boolean scan() {
        // Simulate a virus scan
        System.out.println("Scanning for viruses...");
        return true; // Assume the scan is successful
    }

    @Override
    public String getName() {
        return "Antivirus Security Provider";
    }
}
