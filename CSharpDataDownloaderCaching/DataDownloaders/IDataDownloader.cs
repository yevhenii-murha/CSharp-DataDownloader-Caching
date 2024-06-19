namespace CSharpDataDownloaderCaching.DataDownloaders
{
    public interface IDataDownloader
    {
        string DownloadData(string resourceId);
    }
}
