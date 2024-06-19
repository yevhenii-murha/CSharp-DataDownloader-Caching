using System.Threading;

namespace CSharpDataDownloaderCaching.DataDownloaders
{
    public class SlowDataDownloader : IDataDownloader
    {
        public string DownloadData(string resourceId)
        {
            //let's imagine this method downloads real data,
            //and it does it slowly
            Thread.Sleep(1000);
            return $"Some data for {resourceId}";
        }
    }
}
