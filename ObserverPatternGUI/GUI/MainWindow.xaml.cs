using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Networking;
using Chat;
using Screenshare;
using System.IO.Packaging;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMessageListener
    {
        private readonly Communicator _communicator;
        private readonly IMessageListener _chatListener, _screenshareListener;
        private static new Dispatcher Dispatcher => Application.Current?.Dispatcher ?? Dispatcher.CurrentDispatcher;

        public MainWindow()
        {
            InitializeComponent();

            _communicator = new Communicator();
            _chatListener = new ChatManager();
            _screenshareListener = new ScreenshareManager();
            _communicator.Subscribe(ChatManager.Id, this);
            _communicator.Subscribe(ScreenshareManager.Id, this);

        }

        public void OnMessageReceived(string message, string id)
        {
            Dispatcher.Invoke(() =>
            {
                if (id == ChatManager.Id) ChatReceived.Items.Add(message);
                else if (id == ScreenshareManager.Id) ScreenshareReceived.Items.Add(message);
            });
        }
        private void ChatMessageButton_Click(object sender, RoutedEventArgs e)
        {
            _communicator.SendMessage(MessageTextBox.Text, "chat");
            ChatSent.Items.Add(MessageTextBox.Text);

            MessageTextBox.Clear();
        }

        private void ScreenShareMessageButton_Click(object sender, RoutedEventArgs e)
        {
            _communicator.SendMessage(MessageTextBox.Text, "screenshare");
            ScreenshareSent.Items.Add(MessageTextBox.Text);

            MessageTextBox.Clear();
        }
    }
}