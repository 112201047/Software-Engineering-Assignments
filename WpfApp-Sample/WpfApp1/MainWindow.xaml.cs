using Networking;
using System;
using System.Windows;

namespace WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window, IFileChangedHandler
{
    Communicator _communicator;


    public MainWindow()
    {
        InitializeComponent();

        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        _communicator = new Communicator(path);
        _communicator.Subscribe(this);
    }

    public void OnFileChanged(string filePath)
    {
        Application.Current.Dispatcher.Invoke(() =>
        {
            fileUpdatedTextBlock.Text = $"File updated: {filePath}";

            if (filePath.EndsWith(".png"))
            {
                try
                {
                    var bitmap = new System.Windows.Media.Imaging.BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(filePath);
                    bitmap.CacheOption = System.Windows.Media.Imaging.BitmapCacheOption.OnLoad;
                    bitmap.EndInit();
                    fileUpdatedImage.Source = bitmap;
                }
                catch (Exception ex)
                {
                    fileUpdatedTextBlock.Text += $"\nError loading image: {ex.Message}";
                }
            }
            else
            {
                fileUpdatedImage.Source = null;
            }
        });
    }
}
