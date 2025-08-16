package securityproviders;

public interface ISecurityProvider {
    boolean scan();
    String getName();
    void setNextSecurityProvider(ISecurityProvider securityProvider);
}
