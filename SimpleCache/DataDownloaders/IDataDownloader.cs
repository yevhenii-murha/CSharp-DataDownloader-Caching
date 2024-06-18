namespace Cache.DataDownloaders
{
    public interface IDataDownloader
    {
        string DownloadData(string resourceId);
    }
}
