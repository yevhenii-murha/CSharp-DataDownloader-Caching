using System;

namespace CSharpDataDownloaderCaching.DataDownloaders
{
    public class PrintingDataDownloader : IDataDownloader
    {
        private readonly IDataDownloader _dataDownloader;

        public PrintingDataDownloader(IDataDownloader dataDownloader)
        {
            _dataDownloader = dataDownloader;
        }

        public string DownloadData(string resourceId)
        {
            var data = _dataDownloader.DownloadData(resourceId);
            Console.WriteLine("Data is ready!");
            return data;
        }
    }
}
