using System;

partial class Program
{
    public static async Task  Main(string[] args)
    {
        string filePath = @"D:\Text\downloadedPage.txt";
        string url = "https://www.antimoon.com/";

        int number1 = 7, number2 = 8;

        var text = new DownloadText();

        var task1 = new Task(() => Console.WriteLine("Hello World"));
        var task2 = new Task(() => Thread.Sleep(1000));
        var task3 = new Task(() => Console.WriteLine(number1 + number2));
        var task4 = new Task(() => text.DownloadDataAsync(url, filePath));

        task1.Start();
        task2.Start();
        task3.Start();
        task4.Start();

        Task.WaitAll(task1, task2, task3, task4);
       

        
        
    }
}
