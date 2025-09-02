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
        private static Dispatcher Dispatcher => Application.Current?.Dispatcher ?? Dispatcher.CurrentDispatcher;

        public MainWindow()
        {
            InitializeComponent();

            _communicator = new Communicator();

            _chatListener = new ChatManager(_communicator);
            ((ChatManager)_chatListener).OnChatMessageReceived += message =>
            {
                Dispatcher.Invoke(() => ChatReceived.Items.Add(message));
            };

            _screenshareListener = new ScreenshareManager(_communicator);
            ((ScreenshareManager)_screenshareListener).OnScreenshareMessageReceived += message =>
            {
                Dispatcher.Invoke(() => ScreenshareReceived.Items.Add(message));
            };
        }

        public void OnMessageReceived(string message, string id)
        {
            Console.WriteLine($"\nMainWindow received:\n{message} - {id}");

            Dispatcher.Invoke(() =>
            {
                if (id == ChatManager.Id) ChatSent.Items.Add(message);
                else if (id == ScreenshareManager.Id) ScreenshareSent.Items.Add(message);
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