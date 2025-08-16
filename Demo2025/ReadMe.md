## Object-Oriented Design Demo: Abstraction and Encapsulation

### How This Project Demonstrates OOD Principles

__Abstraction:__

- The `TcpCommunicator` class provides a simple `SendMessage()` method that hides all the complex networking details
- Users don't need to understand sockets, protocols, or handshakes - they just call one method
- The internal steps (OpenSocket, SetProtocol, HandShake, SendData, CloseSocket) are abstracted away

__Encapsulation:__

- Private fields (`_messages`, `Protocol`) are hidden from external access
- Private methods contain implementation details that users shouldn't modify
- Public interface is clean and controlled (`SendMessage()` method and `MessageCount` property)
- Internal state (message count) is protected and can only be changed through controlled methods

### Important Note: File Output Instead of Network

For this demo, we're __writing to a file instead of actually sending over the network__. This makes it easier to see the results without network complexity.

__Where to find the output file:__

- Location: `<Path to your project directory>\Demo2025\Executive\bin\Debug\net8.0`
- File name: `127.0.0.1.txt` (named after the IP address)
- Contents: Shows the protocol used and the message sent

When you run the current program, check that folder and you'll see the file contains something like:

```javascript
Sending via TCP
Hello from here
```

---

## Assignment: Create HttpCommunicator

__Task:__ Write an `HttpCommunicator` class that follows the same OOD principles as `TcpCommunicator`.

__Requirements:__

1. Create the class in the Networking project (right click on the project, and add a new file, call it HttpCommunicator.cs)

2. Use the same public interface pattern:

   - `SendMessage(string message, string ipAddress)` method
   - `MessageCount` property

3. Use HTTP protocol instead of TCP (change the protocol constant)

4. Write to file like the TCP version does

5. Use the HttpCommunicator from Program.cs

6. Verify the output file shows "Sending via HTTP"

__Expected Result:__ When you run your program, the output file should contain:

```javascript
Sending via HTTP
[your message here]
```

This assignment reinforces the same abstraction and encapsulation patterns while giving you practice implementing a similar but different communication protocol.
