# Dependency Inversion Principle - Notification Sercive

This project contains the implementation of the **Dependency Inversion Principle (DIP)** using a notification service example.  
The project demonstrates how high-level modules depend on abstractions (`INotificationProvider`) rather than concrete implementations (SMS, Email, Push).


## Modules
- `notification-providers` (library with notification provider interface and implementations)
- `controller` (console app to demonstrate usage)


## Structure

- **INotificationProvider**: An interface defining the contract for notification providers.  
- **Implementations**:
  - `EmailNotificationProvider`
  - `SMSNotificationProvider`
  - `PushNotificationProvider`
- **NotificationFactory**: Factory class to get the required provider at runtime.  
- **Program**: The console application entry point that uses the factory and interface to send notifications without being tightly coupled to specific implementations.


## Prerequisites
- Java 17+
- Apache Maven 3.8+

## Build
```bash
# From the repo root
cd Java
mvn -q clean package
```

## Run (option A: via Maven Exec)
```bash
cd Java
mvn -q -pl controller exec:java -Dexec.mainClass=controller.Program
```

## Run (option B: shaded JAR)
```bash
cd Java
java -jar controller/target/controller-1.0-SNAPSHOT-shaded.jar
```

## Expected output (sample)
```
Sending notification via SMS Notification Provider
SMS Notification: Test message for notification service
```

Tip: If Maven reports cached plugin resolution errors, retry with:
```bash
mvn -U clean package
```
