using System;
using System.IO;

namespace root_rakendus_Week13_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples";

            Console.WriteLine("Sisesta file nimi:");
            string filenimi = Console.ReadLine();

            string newDirectoryFullPath = $@"{rootDirectory}\{filenimi}";
            bool directoryExists = Directory.Exists(newDirectoryFullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{filenimi} on juba olemas.");
            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Kaust {filenimi} tehti  Samples kausta.");
            }

            Directory.CreateDirectory(newDirectoryFullPath);

        }
    }
}
