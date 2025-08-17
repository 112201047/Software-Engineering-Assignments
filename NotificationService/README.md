# Chain of Responsibility

This project contains the implementation of the design pattern **Chain of Responsibility**.
- Modules:
  - `security-providers` (library with providers)
  - `controller` (console app)

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
Scanning device security...
Scanning for viruses...
Scanning account security...
Scanning online account security...

COMPREHENSIVE SCAN COMPLETED. YOUR DEVICE IS SECURE FROM ALL THREATS.
```

Tip: If Maven reports cached plugin resolution errors, retry with:
```bash
mvn -U clean package
```
