using Cache.DataDownloaders;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDataDownloader dataDownloader = new CachingDataDownloader(new PrintingDataDownloader(new SlowDataDownloader()));

            Console.WriteLine(dataDownloader.DownloadData("ID1"));
            Console.WriteLine(dataDownloader.DownloadData("ID2"));
            Console.WriteLine(dataDownloader.DownloadData("ID3"));
            Console.WriteLine(dataDownloader.DownloadData("ID1"));
            Console.WriteLine(dataDownloader.DownloadData("ID1"));
            Console.WriteLine(dataDownloader.DownloadData("ID2"));
            Console.WriteLine(dataDownloader.DownloadData("ID3"));
            Console.WriteLine(dataDownloader.DownloadData("ID3"));
            Console.WriteLine(dataDownloader.DownloadData("ID4"));
            Console.WriteLine(dataDownloader.DownloadData("ID4"));
        }
    }
}
