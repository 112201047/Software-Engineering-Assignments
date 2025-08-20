package controller;

import notificationproviders.*;

public class Program {
    public static void main(String[] args) {
        // Create the various notification provider instances.
        INotificationProvider notificationProvider = NotificationFactory.getNotificationProvider("sms");

        if (notificationProvider!=null) {
            System.out.println("Sending notification via " + notificationProvider.getName());
            notificationProvider.sendMessage("Test message for notification service");
        }
        else{
            System.out.println("Not a valid Notification Provider");
        }
    }
}
