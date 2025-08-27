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

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Communicator communicator;
        private string _path = "C:\\Users\\nikhi\\Desktop";
        public MainWindow()
        {
            InitializeComponent();

            communicator = new Communicator();
            communicator.SendMessage("Chat Messages", "chat");
            communicator.SendMessage("Screen Share Messages", "screenShare");
            Console.WriteLine("Test Messages sent successfully.\n");
            
            IMessageListener chatListener = new ChatManager(communicator);
            Console.WriteLine("Chat listener subscribed. Waiting for messages...\n");

            IMessageListener screenShareListener = new ScreenshareManager(communicator);
            Console.WriteLine("Screen Share listener subscribed. Waiting for messages...\n");


        }

        private void ChatMessageButton_Click(object sender, RoutedEventArgs e)
        {
            string path = _path+"\\chat_message.txt";
            string message = MessageTextBox.Text;

            System.IO.File.AppendAllText(path, Environment.NewLine + message);
            MessageTextBox.Clear();

            MessagesListBox.Items.Add("Chat message written successfully!\n\nFile contents:\n" + System.IO.File.ReadAllText(path));
        }

        private void ScreenShareMessageButton_Click(object sender, RoutedEventArgs e)
        {
            string path = _path+"\\screenShare_message.txt";
            string message = MessageTextBox.Text;

            System.IO.File.AppendAllText(path, Environment.NewLine + message);
            MessageTextBox.Clear();

            MessagesListBox.Items.Add("Screen Share message written successfully!\n\nFile contents:\n" + System.IO.File.ReadAllText(path));
        }
    }
}