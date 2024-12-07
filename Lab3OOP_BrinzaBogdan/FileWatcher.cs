using System;
using System.IO;

namespace LAB3OOP
{
    public class FileWatcher
    {
        public void WatchDirectory(string directoryPath)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = directoryPath;
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.*";
            watcher.Changed += OnChanged;
            watcher.Created += OnChanged;
            watcher.Deleted += OnChanged;
            watcher.Renamed += OnRenamed;
            watcher.EnableRaisingEvents = true;

            Console.WriteLine($"Watching directory {directoryPath}...");
            Console.ReadLine();
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.FullPath} has been {e.ChangeType}");
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"File {e.OldFullPath} renamed to {e.FullPath}");
        }
    }
}
