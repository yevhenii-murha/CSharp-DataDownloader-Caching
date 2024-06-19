using CSharpDataDownloaderCaching.Caching;

namespace CSharpDataDownloaderCaching.DataDownloaders
{
    public class CachingDataDownloader : IDataDownloader
    {
        private readonly IDataDownloader _dataDownloader;
        private readonly Cache<string, string> _cache = new Cache<string, string>();

        public CachingDataDownloader(IDataDownloader dataDownloader)
        {
            _dataDownloader = dataDownloader;
        }

        public string DownloadData(string resourceId)
        {
            return _cache.Get(resourceId, _dataDownloader.DownloadData);
        }
    }
}
