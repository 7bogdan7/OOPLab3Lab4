using System;
using System.IO;

namespace LAB3OOP
{
    public class FileData
    {
        private string filePath;

        public FileData(string filePath)
        {
            this.filePath = filePath;
        }

        public void ShowFileInfo()
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine($"File Info for {filePath}:");
                var fileInfo = new FileInfo(filePath);
                Console.WriteLine($"Size: {fileInfo.Length} bytes");
                Console.WriteLine($"Creation Time: {fileInfo.CreationTime}");
                Console.WriteLine($"Last Access Time: {fileInfo.LastAccessTime}");
                Console.WriteLine($"Last Write Time: {fileInfo.LastWriteTime}");
            }
            else
            {
                Console.WriteLine($"File {filePath} does not exist.");
            }
        }
    }
}
