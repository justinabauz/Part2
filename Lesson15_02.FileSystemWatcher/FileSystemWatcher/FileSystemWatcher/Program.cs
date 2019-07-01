using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FileSystemWatcherBL;

namespace Lesson15_02_FileSystemWatcher
{
    class Program
    {
        private static MemoryCache FilesToProcess = MemoryCache.Default;

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

                ProcessExistingFiles(directoryToWatch);

                using (var inputFileWatcher = new FileSystemWatcher(directoryToWatch))               
                {
                    inputFileWatcher.IncludeSubdirectories = false;
                    inputFileWatcher.InternalBufferSize = 32768; // 32 KB
                    inputFileWatcher.Filter = "*.*";
                    inputFileWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;

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
            AddToCache(e.FullPath);
        }

        private static void FileChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"* Byla pakeista: {e.Name} - tipas: {e.ChangeType}");
            AddToCache(e.FullPath);
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

        private static void AddToCache(string fullPath)
        {
            var item = new CacheItem(fullPath, fullPath);

            var policy = new CacheItemPolicy
            {
                RemovedCallback = ProcessFile,
                SlidingExpiration = TimeSpan.FromSeconds(2),
            };

            FilesToProcess.Add(item, policy);
        }

        private static void ProcessFile(CacheEntryRemovedArguments args)
        {
            Console.WriteLine($"* Cache item removed: {args.CacheItem.Key} because {args.RemovedReason}");

            if (args.RemovedReason == CacheEntryRemovedReason.Expired)
            {
                var fileProcessor = new FileProcessor(args.CacheItem.Key);
                fileProcessor.Process();
            }
            else
            {
                Console.WriteLine($"WARNING: {args.CacheItem.Key} was removed unexpectedly and may not be processed because {args.RemovedReason}");
            }
        }

        private static void ProcessExistingFiles(string inputDirectory)
        {
            Console.WriteLine($"Checking {inputDirectory} for existing files");

            foreach (var filePath in Directory.EnumerateFiles(inputDirectory))
            {
                Console.WriteLine($"  - Found {filePath}");
                AddToCache(filePath);
            }
        }
    }
}
