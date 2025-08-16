package controller;

import java.util.ArrayList;
import java.util.List;
import securityproviders.*;

public class Program {
    public static void main(String[] args) {
        ISecurityProvider completeSecurity = new CompleteSecurity();
        if (completeSecurity.scan()) {
            System.out.println(completeSecurity.getName() + " scan completed successfully.\n");
            System.out.println("COMPREHENSIVE SCAN COMPLETED. YOUR DEVICE IS SECURE FROM ALL THREATS.\n");
        } else {
            System.out.println(completeSecurity.getName() + " scan failed.\n");
        }

    }
}
