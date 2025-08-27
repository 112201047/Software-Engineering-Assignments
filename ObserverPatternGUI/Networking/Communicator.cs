
namespace Networking
{
    public class Communicator : ICommunicator
    {
        FileSystemWatcher _watcher;
        IMessageListener _listener;
        List<KeyValuePair<string, IMessageListener>> _list;
        private string _path = "C:\\Users\\nikhi\\Desktop";

        public Communicator()
        {
            _watcher = new FileSystemWatcher();
            _watcher.Path = _path;
            _watcher.Filter = "*_message.txt";
            _watcher.NotifyFilter = NotifyFilters.LastWrite;
            _watcher.EnableRaisingEvents = true;
            _watcher.Changed += OnChanged;
            
            _list = new List<KeyValuePair<string, IMessageListener>>();
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (_list != null && e.Name != null)
            {
                var id = e.Name.Split('_')[0];
                _listener = _list.Find(x => x.Key == id).Value;
                if (_listener != null)
                    _listener.OnMessageReceived(File.ReadAllText(e.FullPath));
            }
        }

        public void SendMessage(string message, string id)
        {
            File.WriteAllText(_path + $"\\{id}_message.txt", message);
        }

        public void Subscribe(string id, IMessageListener listener)
        {
            _list.Add(new KeyValuePair<string, IMessageListener>(id, listener));
        }
    }
}
