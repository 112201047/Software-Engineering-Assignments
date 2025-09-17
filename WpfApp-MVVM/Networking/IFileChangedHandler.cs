namespace Networking;

public interface IFileChangedHandler
{
    void OnFileChanged(string filePath);
}
