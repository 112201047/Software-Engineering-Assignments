using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using Networking;

namespace ViewModels;

public class MainWindowViewModel : INotifyPropertyChanged, IFileChangedHandler
{
    private readonly Communicator _communicator;
    private string _latestFileUpdateText = string.Empty;
    public BitmapImage _latestFileUpdateImage = null!;

    public string LatestFileUpdateText
    {
        get
        {
            return _latestFileUpdateText;
        }

        private set
        {
            if (_latestFileUpdateText != value)
            {
                _latestFileUpdateText = value;
                OnPropertyChanged();
            }
        }
    }

    public BitmapImage LatestFileUpdateImage
    {
        get
        {
            return _latestFileUpdateImage;
        }
        private set
        {
            if (_latestFileUpdateImage != value)
            {
                _latestFileUpdateImage = value;
                OnPropertyChanged();
            }
        }
    }

    public MainWindowViewModel()
    {
        var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        _communicator = new Communicator(path);
        _communicator.Subscribe(this);
    }

    public void OnFileChanged(string filePath)
    {
        LatestFileUpdateText = $"File updated: {filePath}";
        if (filePath.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
        {
            try
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(filePath);
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit();
                bitmap.Freeze(); // Freeze to make it cross-thread accessible
                LatestFileUpdateImage = bitmap;
            }
            catch (Exception ex)
            {
                LatestFileUpdateText += $"\nError loading image: {ex.Message}";
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
