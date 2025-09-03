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
    public partial class MainWindow : Window
    {
        private readonly Communicator _communicator;
        private readonly ChatManager _chatManager;
        private readonly ScreenshareManager _screenshareManager;
        private static new Dispatcher Dispatcher => Application.Current?.Dispatcher ?? Dispatcher.CurrentDispatcher;

        public MainWindow()
        {
            InitializeComponent();

            _communicator = new Communicator();

            _chatManager = new ChatManager();
            _screenshareManager = new ScreenshareManager();

            _chatManager.OnChatMessageReceived += message =>
                Dispatcher.Invoke(() => ChatReceived.Items.Add(message));

            _screenshareManager.OnScreenshareMessageReceived += message =>
                Dispatcher.Invoke(() => ScreenshareReceived.Items.Add(message));

            _communicator.Subscribe(ChatManager.Id, _chatManager);
            _communicator.Subscribe(ScreenshareManager.Id, _screenshareManager);

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