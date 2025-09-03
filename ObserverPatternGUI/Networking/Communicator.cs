
namespace Networking
{
    public class Communicator : ICommunicator
    {
        FileSystemWatcher _watcher;
        List<KeyValuePair<string, IMessageListener>> _list;
        private string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public Communicator()
        {
            _watcher = new FileSystemWatcher();
            _watcher.Path = _path;
            _watcher.Filter = "in.txt";
            _watcher.NotifyFilter = NotifyFilters.LastWrite;
            _watcher.EnableRaisingEvents = true;
            _watcher.Changed += OnChanged;
            
            _list = new List<KeyValuePair<string, IMessageListener>>();
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (_list != null)
            {
                string[] lines = File.ReadAllLines(e.FullPath);
                foreach (string line in lines)
                {
                    var id = line.Split(": ")[0];
                    string message = line.Split(": ")[1];
                    var listener = _list.Find(x => x.Key == id).Value;
                    listener?.OnMessageReceived(message, id);
                }
            }
        }

        public void SendMessage(string message, string id)
        {
            File.AppendAllText(_path + "\\out.txt", $"{id}: {message}\n");
        }

        public void Subscribe(string id, IMessageListener listener)
        {
            _list.Add(new KeyValuePair<string, IMessageListener>(id, listener));
        }
    }
}
