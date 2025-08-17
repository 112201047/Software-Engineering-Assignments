package notificationproviders;

public class NotificationFactory {
    public static INotificationProvider getNotificationProvider(String type){
        return switch (type) {
            case "sms" -> new SMSNotificationProvider();
            case "email" -> new EmailNotificationProvider();
            case "push" -> new PushNotificationProvider();
            default -> null;
        };
    }
}
