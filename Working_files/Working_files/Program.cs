using System;
using System.IO;
using WorkingWithFilesBL;

namespace Working_files
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Analizuoju komandines eilutes parametrus");
            var command = args[0];
            if (command  == "--file")
            {
                var filePath = args[1];
                Console.WriteLine($"Pasirinkta viena byla {filePath}");
                ProcessSingleFile(filePath);
            }

            else if (command == "--dir")
            {
                var directoryPath = args[1];
                var fileType = args[2];

                Console.WriteLine($"Pasirinktas katalogas {directoryPath} ir bylos tipas {fileType}");
                ProcessDirectory(directoryPath, fileType);
            }

            else 
            {
                Console.WriteLine("Nezinomas komandines eilutes parametras {0}", command);
                     
            }

            Console.WriteLine("Press Enter to quit.");

        }
        private static void ProcessSingleFile(string filePath)
        {
            Console.WriteLine("Gavau bylos varda {0}", filePath);


            var fileProcessor = new FileProcessor(filePath);
            fileProcessor.Process();
        
        }

        private static void ProcessDirectory(string directoryPath, string fileType)

        {
            Console.WriteLine("Gavau aplankalo pavadinima {0} ir bylu tipa {1}", directoryPath, fileType);
            switch (fileType)
            {
                case "TEXT":
                    string[] textFiles = Directory.GetFiles(directoryPath, "*.txt");
                    foreach (var textFilePath in textFiles)
                    {
                        Console.WriteLine(textFilePath);
                        var fileProcessor = new FileProcessor(textFilePath);
                        fileProcessor.Process();
                    }
                    break;
                default:
                    Console.WriteLine($"KLAIDA: nepalaikomas tipas {fileType} ");
                    return;
            }

        }
    }
}
