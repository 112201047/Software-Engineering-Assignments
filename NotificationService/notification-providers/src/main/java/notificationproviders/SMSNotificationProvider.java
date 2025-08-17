package notificationproviders;

public class SMSNotificationProvider implements INotificationProvider {
    public SMSNotificationProvider() {
        // Constructor logic if needed
    }

    @Override
    public void sendMessage(String message){
        // Actual implementation of sending message

        // Simulating sending a message
        System.out.println("SMS Notification: "+message);
    }

    @Override
    public String getName() {
        return "SMS Notification Provider";
    }
}
