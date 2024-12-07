using System;

namespace LAB3OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentChangeDetectionSystem changeDetectionSystem = new DocumentChangeDetectionSystem();

            while (true)
            {
                int input = UseMenu();
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Enter file path to commit:");
                        string? filePath = Console.ReadLine();
                        if (!string.IsNullOrEmpty(filePath))
                        {
                            changeDetectionSystem.SaveSnapshot(filePath);
                        }
                        else
                        {
                            Console.WriteLine("File path cannot be null or empty.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter file path to show info:");
                        string? fileInfoPath = Console.ReadLine();
                        if (!string.IsNullOrEmpty(fileInfoPath))
                        {
                            FileData fileData = new FileData(fileInfoPath);
                            fileData.ShowFileInfo();
                        }
                        else
                        {
                            Console.WriteLine("File path cannot be null or empty.");
                        }
                        break;

                    case 3:
                        changeDetectionSystem.ShowFileStatus();
                        break;

                    case 4:
                        changeDetectionSystem.ShowChanges();
                        break;

                    case 5:
                        Console.WriteLine("Enter version number:");
                        string? versionNumber = Console.ReadLine();
                        if (!string.IsNullOrEmpty(versionNumber))
                        {
                            Console.WriteLine($"Restoring version {versionNumber}...");
                        }
                        else
                        {
                            Console.WriteLine("Version number cannot be null or empty.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static public int UseMenu()
        {
            Console.WriteLine($"<--*---*----* ************* *---*---*--->");
            Console.WriteLine($"------------- ------------- -------------");
            Console.WriteLine("Enter command (COMMIT, info <filename>, get STATUS, EXIT): ");
            Console.WriteLine($"1 - - - > COMMIT - - - ");
            Console.WriteLine($"2 - - - > info <filename> - - - ");
            Console.WriteLine($"3 - - - > get STATUS - - - ");
            Console.WriteLine($"4 - - - > CHANGES - - - ");
            Console.WriteLine($"5 - - - > One VERSION OF THE FILES - - - ");
            Console.WriteLine($"0 - - - > EXIT - - - ");
            Console.WriteLine($"------------- ------------- -------------");
            Console.WriteLine($"<--*---*----* ************* *---*---*--->");
            int.TryParse(Console.ReadLine(), out int input);
            return input;
        }
    }
}
