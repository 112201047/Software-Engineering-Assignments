
namespace Networking;

public class Communicator
{
    FileSystemWatcher _watcher;
    IFileChangedHandler? _handler;

    public Communicator(string path)
    {
        _watcher = new FileSystemWatcher(path);
        _watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.CreationTime;
        _watcher.Filter = "*.*";
        _watcher.Created += OnChanged; // Ok to have created and changed both point to OnChanged
        _watcher.Changed += OnChanged;
        _watcher.EnableRaisingEvents = true;
    }

    public void Subscribe(IFileChangedHandler handler)
    {
        _handler = handler;
    }

    private void OnChanged(object sender, FileSystemEventArgs e)
    {
        if (_handler != null && e.Name!= null)
        {
            string ext = Path.GetExtension(e.Name).ToLower();
            if (ext == ".txt" || ext == ".png")
            {
                _handler.OnFileChanged(e.FullPath);
            }
        }
    }
}
