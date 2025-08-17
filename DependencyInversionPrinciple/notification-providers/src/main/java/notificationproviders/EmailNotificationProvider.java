package notificationproviders;

public class EmailNotificationProvider implements INotificationProvider {
    public EmailNotificationProvider() {
        // Constructor logic if needed
    }

    @Override
    public void sendMessage(String message){
        // Actual implementation of sending message

        // Simulating sending a message
        System.out.println("Email Notification: "+message);
    }

    @Override
    public String getName() {
        return "Email Notification Provider";
    }
}
