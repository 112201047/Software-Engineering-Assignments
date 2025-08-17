package securityproviders;

public class AccountSecurityProvider implements ISecurityProvider {
    protected ISecurityProvider next;

    public AccountSecurityProvider() {
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
        System.out.println("Scanning account security...");
        if (next!=null){
            result = result && next.scan();
        }
        return result;
    }

    @Override
    public String getName() {
        return "Account Security Provider";
    }
}
