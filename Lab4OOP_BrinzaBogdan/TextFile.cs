using System;
using System.IO;

namespace DocumentChangeDetection
{
    public class TextFile : FileBase
    {
        public int LineCount { get; private set; }
        public int WordCount { get; private set; }
        public int CharacterCount { get; private set; }

        public TextFile(string filePath)
        {
            FileName = Path.GetFileName(filePath);
            Extension = Path.GetExtension(filePath);
            CreationDate = File.GetCreationTime(filePath);
            LastUpdatedDate = File.GetLastWriteTime(filePath);
            AnalyzeFile(filePath);
        }

        private void AnalyzeFile(string filePath)
        {
            string content = File.ReadAllText(filePath);
            LineCount = content.Split('\n').Length;
            WordCount = content.Split(' ', '\n').Length;
            CharacterCount = content.Length;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"File: {FileName}, Type: Text");
            Console.WriteLine($"Lines: {LineCount}, Words: {WordCount}, Characters: {CharacterCount}");
        }
    }
}
