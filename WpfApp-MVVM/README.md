# Desktop File Change Notifier (WPF App — MVVM)

This is a lightweight WPF application that monitors the desktop for file changes, structured using the **MVVM pattern**.  
It was extended from [@ramaswamy-krishnan-chittur](https://github.com/chittur)’s sample project to:

- Display the names of modified `.txt` and `.png` files.  
- Show the contents of a `.png` file in an **Image control** when it is added or updated.  
- Separate responsibilities clearly via a **ViewModel**.  

## Features

- Monitors the desktop for file changes using `FileSystemWatcher`.  
- Displays the name of the updated file in the GUI.  
- Supports:
  - **`.txt` files** → displays file name in a `TextBlock`.  
  - **`.png` files** → displays file name and renders the image in an `Image` control.  
- Clean MVVM structure:  
  - `Communicator` → monitors filesystem.  
  - `MainWindowViewModel` → exposes bindable state.  
  - `MainWindow.xaml` → binds UI to ViewModel.  

## How It Works

1. `Communicator` uses `FileSystemWatcher` to monitor the **Desktop folder**.  
2. It raises an event when `.txt` or `.png` files are created/changed.  
3. `MainWindowViewModel` receives the notification and updates its bindable properties.  
4. `MainWindow.xaml` automatically reflects updates via data binding:
   - Updates a `TextBlock` with the file name.  
   - If the file is `.png`, loads and displays it in an `Image` control.  
