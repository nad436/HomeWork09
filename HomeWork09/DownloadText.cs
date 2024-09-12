partial class Program
{
    private class DownloadText
    {
        public  async void DownloadDataAsync(string url, string filePath)
        {
            HttpClient text = new HttpClient();

            string response = await text.GetStringAsync(url);
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            await File.WriteAllTextAsync(filePath, response);
            Console.WriteLine($"Content saved to {filePath}");
        }
    }
}
