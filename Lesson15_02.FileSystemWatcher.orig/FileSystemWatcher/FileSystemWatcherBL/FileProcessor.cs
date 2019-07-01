using System;
using System.IO;

namespace FileSystemWatcherBL
{
    public class FileProcessor
    {
        private static readonly string _backupDirectoryName = "backup";
        private static readonly string _inProgressDirectoryName = "processing";
        private static readonly string _completedDirectoryName = "complete";

        public string InputFilePath { get; }

        public FileProcessor(string filePath)
        {
            InputFilePath = filePath;
        }

        public void Process()
        {
            Console.WriteLine($"Pradedu bylos apdorojima {InputFilePath}");

            // Check if file exists
            if (!File.Exists(InputFilePath))
            {
                Console.WriteLine($"KLAIDA: byla {InputFilePath} neegzistuoja.");
                return;
            }

            string rootDirectoryPath = new DirectoryInfo(InputFilePath).Parent.Parent.FullName;
            Console.WriteLine($"Sakninis katalogas yra {rootDirectoryPath}");

            // Check if backup dir exists
            string inputFileDirectoryPath = Path.GetDirectoryName(InputFilePath);
            string backupDirectoryPath = Path.Combine(rootDirectoryPath, _backupDirectoryName);

            if(!Directory.Exists(backupDirectoryPath))
            {
                Console.WriteLine($"Kuriamas {backupDirectoryPath}");
                Directory.CreateDirectory(backupDirectoryPath);
            }

            // Copy file to backup dir
            string inputFileName = Path.GetFileName(InputFilePath);
            string backupFilePath = Path.Combine(backupDirectoryPath, inputFileName);
            Console.WriteLine($"Kpijuoju {InputFilePath} i {backupFilePath}");
            File.Copy(InputFilePath, backupFilePath);

            // Move to in progress dir
            Directory.CreateDirectory(Path.Combine(rootDirectoryPath, _inProgressDirectoryName));

            string inProgressFilePath =
                Path.Combine(rootDirectoryPath, _inProgressDirectoryName, inputFileName);

            if (File.Exists(inProgressFilePath))
            {
                Console.WriteLine($"KLAIDA: byla {inProgressFilePath} jau apdorota.");
                return;
            }

            Console.WriteLine($"Perkeliu {InputFilePath} iu {inProgressFilePath}");
            File.Move(InputFilePath, inProgressFilePath);


            // Determine type of file
            string extension = Path.GetExtension(InputFilePath);
            switch (extension)
            {
                case ".txt":
                    ProcessTextFile(inProgressFilePath);
                    break;
                default:
                    Console.WriteLine($"Nepalaikomas bylos tipas {extension}");
                    break;
            }

            string completedDirectoryPath = Path.Combine(rootDirectoryPath, _completedDirectoryName);
            Directory.CreateDirectory(completedDirectoryPath);

            Console.WriteLine($"Perkelimas {inProgressFilePath} i {completedDirectoryPath}");
            var completedFileName = string.Format(
                "{0}-{1}{2}", 
                Path.GetFileNameWithoutExtension(InputFilePath), Guid.NewGuid(), extension);

            var completedFilePath = Path.Combine(completedDirectoryPath, completedFileName);
            File.Move(inProgressFilePath, completedFilePath);

            string inProgressDirectoryPath = Path.GetDirectoryName(inProgressFilePath);
            Directory.Delete(inProgressDirectoryPath, true);
        }

        private void ProcessTextFile(string inProgressFilePath)
        {
            Console.WriteLine($"Apdorojama byla {inProgressFilePath}");
            // Read in and process
        }
    }
}