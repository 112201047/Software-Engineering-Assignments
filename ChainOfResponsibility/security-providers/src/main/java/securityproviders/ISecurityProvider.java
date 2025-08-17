package securityproviders;

public interface ISecurityProvider {
    boolean scan();
    String getName();
    ISecurityProvider setNext(ISecurityProvider nextSecurityProvider);
}
