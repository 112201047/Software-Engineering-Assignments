# Desktop File Change Notifier (WPF App)

This is a lightweight WPF application (about 70 lines of core code) that monitors the desktop for file changes.  
It was extended from [@ramaswamy-krishnan-chittur](https://github.com/chittur)’s sample project to:

- Display the names of modified `.txt` and `.png` files.  
- Show the contents of a `.png` file in an **Image control** when it is added or updated.  


## Features

- Monitors the desktop for file changes using `FileSystemWatcher`.  
- Displays the name of the updated file in the GUI.  
- Supports:
  - **`.txt` files** → displays file name in a `TextBlock`.  
  - **`.png` files** → displays file name and renders the image in an `Image` control.  
- Lightweight and easily extensible.  

## How It Works

1. `Communicator` uses `FileSystemWatcher` to monitor the **Desktop folder**.  
2. It triggers an event when `.txt` or `.png` files are created/changed.  
3. `MainWindow` (which implements `IFileChangedHandler`) receives the notification.  
4. The app:
   - Updates a `TextBlock` with the file name.  
   - If the file is `.png`, loads and displays it in an `Image` control. 
