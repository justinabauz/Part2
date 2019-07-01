using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSystemWatcherBL;

namespace Lesson15_02_FileSystemWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Analizuoju komandinės eilutės parametrus");

            var directoryToWatch = args[0];

            if (!Directory.Exists(directoryToWatch))
            {
                Console.WriteLine($"KLAIDA: katalogas neegzistuoja {directoryToWatch} ");
            }
            else
            {
                Console.WriteLine($"Pradedu pakitimu stebejima {directoryToWatch} ");
                using (var inputFileWatcher = new FileSystemWatcher(directoryToWatch))
                {
                    inputFileWatcher.IncludeSubdirectories = false;
                    inputFileWatcher.InternalBufferSize = 32768; // 32 KB
                    inputFileWatcher.Filter = "*.*";
                    inputFileWatcher.NotifyFilter = /*NotifyFilters.FileName | */NotifyFilters.LastWrite;

                    inputFileWatcher.Created += FileCreated;
                    inputFileWatcher.Changed += FileChanged;
                    inputFileWatcher.Deleted += FileDeleted;
                    inputFileWatcher.Renamed += FileRenamed;
                    inputFileWatcher.Error += WatcherError;

                    inputFileWatcher.EnableRaisingEvents = true;

                    Console.WriteLine("Press enter to quit.");
                    Console.ReadLine();
                }
            }
        }

        private static void FileCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"* Byla sukurta: {e.Name} - tipas: {e.ChangeType}");
        }

        private static void FileChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"* Byla pakeista: {e.Name} - tipas: {e.ChangeType}");
        }

        private static void FileDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"* Byla istrinta: {e.Name} - tipas: {e.ChangeType}");
        }

        private static void FileRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"* Byla pervadinta: {e.OldName} i {e.Name} - tipas: {e.ChangeType}");
        }

        private static void WatcherError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine($"KLAIDA: file system watching negali testi darbo: {e.GetException()}");
        }
        
        private static void ProcessSingleFile(string filePath)
        {
            var fileProcessor = new FileProcessor(filePath);
            fileProcessor.Process();
        }

        private static void ProcessDirectory(string directoryPath, string fileType)
        {
            switch (fileType)
            {
                case "TEXT":
                    string[] textFiles = Directory.GetFiles(directoryPath, "*.txt");
                    foreach (var textFilePath in textFiles)
                    {
                        Console.WriteLine(textFilePath);
                        //var fileProcessor = new FileProcessor(textFilePath);
                        //fileProcessor.Process();
                    }
                    break;
                default:
                    Console.WriteLine($"KLAIDA: nepalaikomas tipas {fileType} ");
                    return;
            }
        }
    }
}
