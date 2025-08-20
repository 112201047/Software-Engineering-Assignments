package notificationproviders;

public interface INotificationProvider {
    void sendMessage(String message);
    String getName();
}
