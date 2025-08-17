package notificationproviders;

public class PushNotificationProvider implements INotificationProvider {
    public PushNotificationProvider() {
        // Constructor logic if needed
    }

    @Override
    public void sendMessage(String message){
        // Actual implementation of sending message

        // Simulating sending a message
        System.out.println("Push Notification: "+message);
    }

    @Override
    public String getName() {
        return "Push Notification Provider";
    }
}
