package securityproviders;

public class DeviceSecurity implements ISecurityProvider {
    private ISecurityProvider next;

    public DeviceSecurity() {
        // Constructor logic if needed
    }

    @Override
    public ISecurityProvider setNext(ISecurityProvider nextSecurityProvider){
        this.next = nextSecurityProvider;
        return nextSecurityProvider;
    }

    @Override
    public boolean scan() {
        // Simulate a device security scan
        boolean result = true;  // Actual scanning method goes here
        System.out.println("Scanning device security...");
        if (next!=null){
            result = result && next.scan();
        }
        return result;
    }

    @Override
    public String getName() {
        return "Device Security Provider";
    }
}
