package controller;

import java.util.ArrayList;
import java.util.List;
import securityproviders.*;

public class Program {
    public static void main(String[] args) {
        // Create the various security provider instances.
        ISecurityProvider deviceSecurity = new DeviceSecurity();
        ISecurityProvider onlineAccountSecurity = new OnlineAccountSecurityProvider();
        ISecurityProvider accountSecurity = new AccountSecurityProvider();
        ISecurityProvider antivirusSecurity = new AntivirusSecurityProvider();

        // Create a list of security providers.
        List<ISecurityProvider> securityProviders = new ArrayList<>();
        securityProviders.add(deviceSecurity);
        securityProviders.add(onlineAccountSecurity);
        securityProviders.add(accountSecurity);
        securityProviders.add(antivirusSecurity);

        // Iterate through each security provider and perform a scan.
        for (ISecurityProvider provider : securityProviders) {
            System.out.println("Using " + provider.getName());
            if (provider.scan()) {
                System.out.println(provider.getName() + " scan completed successfully.\n");
            } else {
                System.out.println(provider.getName() + " scan failed.\n");
            }
        }
    }
}
