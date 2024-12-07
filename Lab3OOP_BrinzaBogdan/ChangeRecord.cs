using System;

namespace LAB3OOP
{
    public class ChangeRecord
    {
        public string FilePath { get; set; }
        public string ChangeDescription { get; set; }
        public DateTime ChangeTime { get; set; }

        public ChangeRecord(string filePath, string changeDescription)
        {
            FilePath = filePath;
            ChangeDescription = changeDescription;
            ChangeTime = DateTime.Now;
        }

        public void ShowChangeDetails()
        {
            Console.WriteLine($"File: {FilePath}");
            Console.WriteLine($"Change: {ChangeDescription}");
            Console.WriteLine($"Time: {ChangeTime}");
        }
    }
}
