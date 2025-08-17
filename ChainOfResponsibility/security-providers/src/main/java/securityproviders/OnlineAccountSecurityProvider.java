package securityproviders;

public class OnlineAccountSecurityProvider extends AccountSecurityProvider implements ISecurityProvider {
    private ISecurityProvider next;

    public OnlineAccountSecurityProvider() {
        // Constructor logic if needed
    }

    @Override
    public boolean scan() {
        // Simulate a device security scan
        boolean result = true;  // Actual scanning method goes here
        System.out.println("Scanning online account security...");
        if (next!=null){
            result = result && next.scan();
        }
        return result;
    }

    @Override
    public String getName() {
        return "Online Account Security Provider";
    }
}
