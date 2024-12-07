using System;
using System.Collections.Generic;
using System.IO;

namespace LAB3OOP
{
    public class DocumentChangeDetectionSystem
    {
        private Dictionary<int, Dictionary<string, Dictionary<int, string>>> fileSnapshot = new();
        public int VersionsNumber { get; private set; }

        public void SaveSnapshot(string filePath)
        {
            Dictionary<int, string> one_fileSnapshot = File.ReadAllLines(filePath)
                .Select((line, index) => new { index, line })
                .ToDictionary(x => x.index + 1, x => x.line);

            int nextVersion = fileSnapshot.Keys.DefaultIfEmpty(0).Max() + 1;

            if (!fileSnapshot.ContainsKey(nextVersion))
            {
                fileSnapshot[nextVersion] = new Dictionary<string, Dictionary<int, string>>();
            }

            fileSnapshot[nextVersion][filePath] = one_fileSnapshot;
            VersionsNumber++;
        }

        public void ShowChanges()
        {
            foreach (var version in fileSnapshot)
            {
                Console.WriteLine($"Version {version.Key}:");
                foreach (var file in version.Value)
                {
                    Console.WriteLine($"File: {file.Key}");
                    foreach (var line in file.Value)
                    {
                        Console.WriteLine($"Line {line.Key}: {line.Value}");
                    }
                }
            }
        }

        public void ShowFileStatus()
        {
            foreach (var version in fileSnapshot)
            {
                Console.WriteLine($"Version {version.Key}:");
                foreach (var file in version.Value)
                {
                    Console.WriteLine($"File: {file.Key} - Status: Changed");
                }
            }
        }
    }
}
