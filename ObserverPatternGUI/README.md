# Observer Pattern with WPF UI and Console Output

This project demonstrates the **Observer Design Pattern** by integrating a **WPF User Interface** with a **console backend**.  

## Overview
- **WPF UI (Publisher):**
  - Provides buttons and text boxes for sending messages.
  - Messages are categorized into:
    - **Chat Messages**
    - **Screen Share Messages**
  - Messages are written to text files:
    - `chat_message.txt`
    - `screenShare_message.txt`

- **Console Window (Observer):**
  - Runs alongside the UI (once output type is set to Console Application).
  - Displays:
    - Debug/test messages.
    - Logs when observers are subscribed.
    - The messages being read from the files.

This shows how the **Observer Pattern** allows decoupled communication:  
- The **UI writes messages (state changes)**.  
- The **Console (observers)** reacts automatically.


## Working
1. **Set Project Output to Console:**
   - In Visual Studio:
     - Right-click the project `GUI` → **Properties**.
     - Go to **Application** tab.
     - Set **Output type** → **Console Application**.
   - Run the project → both the **WPF window** and a **console window** open.

2. **Flow of Execution:**
   - `Communicator` sends initial test messages.
   - `ChatManager` and `ScreenshareManager` subscribe as observers.
   - When you send a message in the UI:
     - It is appended to the respective file.
     - The console displays the subscription logs and prints messages as they are processed.


## Usage
1. Open the project in **Visual Studio**.
2. Change **Output type** → `Console Application`.
3. Run the project. You’ll see:
   - A **WPF window** for sending messages.
   - A **console window** showing debug and observer logs.
4. In the UI:
   - Enter a message in the text box.
   - Click:
     - **Chat Message Button** → writes to `chat_message.txt`.
     - **Screen Share Message Button** → writes to `screenShare_message.txt`.
5. Console window will show:
   - Observer subscription logs.
   - New messages as they are written.


## Observer Pattern in This Project

The project follows the **Observer Pattern**:

- **Subject (Publisher):**  
  - `Communicator`  
  - Maintains a list of subscribers (`Subscribe`) and broadcasts messages using `SendMessage`.

- **Observers (Subscribers):**  
  - `ChatManager`  
  - `ScreenshareManager`  
  - `Listener` (test listener)  
  - Each implements the `IMessageListener` interface and defines `OnMessageReceived(string message)`.

- **Sample Notification Flow:**  
  1. `Communicator.SendMessage("Hello", "chat")` → triggers a state change.  
  2. `Communicator` notifies all listeners subscribed to `"chat"`.  
  3. Each observer’s `OnMessageReceived` method is called.  
  4. Observers react individually (e.g., printing to console).

