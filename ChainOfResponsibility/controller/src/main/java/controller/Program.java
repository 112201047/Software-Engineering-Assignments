package controller;

import securityproviders.*;

public class Program {
    public static void main(String[] args) {
        // Create the various security provider instances.
        ISecurityProvider deviceSecurity = new DeviceSecurity();
        ISecurityProvider onlineAccountSecurity = new OnlineAccountSecurityProvider();
        ISecurityProvider accountSecurity = new AccountSecurityProvider();
        ISecurityProvider antivirusSecurity = new AntivirusSecurityProvider();

        // Create chain of security providers.
        deviceSecurity.setNext(antivirusSecurity).setNext(accountSecurity).setNext(onlineAccountSecurity);

        // Invoke the chain by calling scan() only on the head.
        boolean completeScan = deviceSecurity.scan();
        if (completeScan){
            System.out.println("\nCOMPREHENSIVE SCAN COMPLETED. YOUR DEVICE IS SECURE FROM ALL THREATS.");
        }
        else{
            System.out.println("\nScanning failed. Your device is not secure from all threats.");
        }
    }
}
