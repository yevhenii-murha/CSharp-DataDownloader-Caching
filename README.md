# CSharp-DataDownloader-Caching

This project demonstrates a data caching mechanism implemented in C# to optimize data retrieval operations using decorators and caching strategies.

## Overview

The `CSharpDataDownloaderCaching` project showcases how to improve the performance of data downloading operations by introducing a caching layer. It utilizes the decorator pattern to stack data downloaders and a caching layer, ensuring efficient resource utilization and reduced latency.

### Components

1. **SlowDataDownloader**: Simulates a slow data downloading process by introducing a delay using `Thread.Sleep(1000)`.

2. **PrintingDataDownloader**: Decorator that wraps a data downloader and prints a message when data is ready.

3. **CachingDataDownloader**: Decorator that adds caching functionality to a data downloader, avoiding redundant downloads for the same resource ID.

4. **Cache<TKey, TData>**: Simple in-memory cache implementation using a dictionary.

## Usage

To observe the caching mechanism in action, run the `Main` method in `Program.cs`:

```csharp
static void Main(string[] args)
{
    IDataDownloader dataDownloader = new CachingDataDownloader(new PrintingDataDownloader(new SlowDataDownloader()));

    Console.WriteLine(dataDownloader.DownloadData("ID1"));
    Console.WriteLine(dataDownloader.DownloadData("ID2"));
    Console.WriteLine(dataDownloader.DownloadData("ID3"));
    Console.WriteLine(dataDownloader.DownloadData("ID1")); // Cached result
    Console.WriteLine(dataDownloader.DownloadData("ID1")); // Cached result
    Console.WriteLine(dataDownloader.DownloadData("ID2")); // Cached result
    Console.WriteLine(dataDownloader.DownloadData("ID3")); // Cached result
    Console.WriteLine(dataDownloader.DownloadData("ID3")); // Cached result
    Console.WriteLine(dataDownloader.DownloadData("ID4"));
    Console.WriteLine(dataDownloader.DownloadData("ID4")); // Cached result
}
```

This example demonstrates how the caching layer (`CachingDataDownloader`) efficiently manages data downloads, preventing redundant calls to the slow data downloader (`SlowDataDownloader`) for resources that have been cached.

## Installation

To run the project locally:

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or your preferred IDE.
3. Build the solution.
4. Run the executable or start debugging to observe the caching behavior.
