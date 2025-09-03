# Observer Pattern with WPF Messaging App 

This project demonstrates the **Observer Design Pattern** using a **WPF User Interface** that exchanges messages via a `Communicator` backend.  
Messages are sent and received through text files (`in.txt` and `out.txt`) using the **FileSystemWatcher** mechanism.

## Overview

- **WPF UI**
  - Provides text input and buttons for sending:
    - **Chat messages**
    - **Screenshare messages**
  - Displays both **sent** and **received** messages in the UI.

- **Communicator (Publisher)**
  - Watches `in.txt` for new incoming messages.
  - Writes outgoing messages to `out.txt`.
  - Notifies all subscribed managers when new messages arrive.

- **Observers (Subscribers)**
  - `ChatManager` → handles chat messages.
  - `ScreenshareManager` → handles screenshare messages.
  - Both implement the `IMessageListener` interface.

## How It Works

1. **Startup**
   - `MainWindow` creates a single `Communicator`.
   - `ChatManager` and `ScreenshareManager` subscribe to it.
   - Event handlers update the UI whenever messages are received.

2. **Sending a Message**
   - User types into the textbox and clicks:
     - **Send Chat Message Button** → sends via `"chat"`.
     - **Send Screenshare Message Button** → sends via `"screenshare"`.
   - `Communicator.SendMessage` appends the message into `out.txt`.

3. **Receiving a Message**
   - `Communicator` monitors `in.txt` using a `FileSystemWatcher`.
   - Whenever `in.txt` changes, all new lines are read.
   - Each line is in the format:
     ```
     id: message
     ```
     Example:
     ```
     chat: Hello World
     screenshare: Sharing my screen now
     ```
   - Based on the `id`, the correct manager (`ChatManager` or `ScreenshareManager`) is notified.
   - The message is displayed in the WPF UI under **received messages**.


## Usage Instructions

1. **Run the Project**
   - Build and run the WPF project (`GUI`).
   - The main window will open with sections for chat and screenshare.

2. **Send Messages from UI**
   - Type text in the message box.
   - Click the **Send Chat Message** or **Send Screenshare Message** button.
   - Sent messages appear in:
     - `ChatSent` / `ScreenshareSent` lists in the UI.
     - Appended to `out.txt` on your Desktop.

3. **Provide Input (to simulate external sender)**
   - Open `in.txt` on your Desktop (create it if it doesn’t exist).
   - Add a new line in the format:
     ```
     chat: Hi from file
     screenshare: File triggered update
     ```
   - Save the file → The WPF UI immediately updates under **Received Chat Messages** or **Received Screenshare Messages**.

4. **View Output**
   - **Sent messages** → written to `out.txt`.
   - **Received messages** → shown in the UI (and come from `in.txt`).


## Observer Pattern in This Project

- **Publisher (Subject)**
  - `Communicator`
  - Keeps a list of `(id, listener)` pairs.
  - Writes outgoing messages to `out.txt`.
  - Watches `in.txt` for incoming messages and notifies subscribers.

- **Subscribers (Observers)**
  - `ChatManager` → subscribes with `id = "chat"`.
  - `ScreenshareManager` → subscribes with `id = "screenshare"`.
  - Both react to incoming messages via their `OnMessageReceived` implementation.

## Files Used

- **`in.txt`** → Input file (simulate external messages).  
- **`out.txt`** → Output file (stores sent messages).  

Both files are located on the **Desktop** by default.
