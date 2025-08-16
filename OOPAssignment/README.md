# Object Oriented Programming Project

This project implements the program discussed in class, which demonstrates **object-oriented design** with multiple communicator classes and a controller module.

## Description
The program defines:
- **`ICommunicator`** – Interface that specifies the communicator contract.  
- **`ProtocolCommunicatorBase`** – Abstract base class that provides common functionality for protocol-based communicators.  
- **`TcpCommunicator`** – Simulated implementation using TCP protocol.  
- **`UdpCommunicator`** – Simulated implementation using UDP protocol.  
- **`RemoteProcedureCallCommunicator`** – Simulated implementation for RPC communication.  
- **`Controller`** – Uses the communicators to perform operations.  

## Class Diagram
Below is the class diagram representing the relationships among the classes:

![Class Diagram](./Class%20Diagram.jpg)
