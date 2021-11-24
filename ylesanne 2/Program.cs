using System;
using System.IO;

namespace ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\Proov";
            string userToyota = "toyota";
            string userBmw = "bmw";
            string userTesla = "tesla";
            string fullToyotaPath = $@"{rootDirectory}\{userToyota}.txt";
            string fullBmwPath = $@"{rootDirectory}\{userBmw}.txt";
            string fullTeslaPath = $@"{rootDirectory}\{userTesla}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileToyotaExists = File.Exists(fullToyotaPath);
            bool fileBmwExists = File.Exists(fullBmwPath);
            bool fileTeslaExists = File.Exists(fullTeslaPath);

            if (directoryExists && fileToyotaExists && fileBmwExists && fileTeslaExists)
            {
                Console.WriteLine($"{userToyota} and {userBmw} and {userTesla} already exists in {rootDirectory}");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"{rootDirectory} does not exist.");
                Directory.CreateDirectory(rootDirectory);
                Console.WriteLine($"{rootDirectory} has been created.");
                File.Create(fullToyotaPath);
                File.Create(fullBmwPath);
                File.Create(fullTeslaPath);
                Console.WriteLine($"{userToyota}.txt and {userBmw}.txt and {userTesla}.txt have been created in {rootDirectory}.");

            }
            else
            {
                File.Create(fullToyotaPath);
                File.Create(fullBmwPath);
                File.Create(fullTeslaPath);

                Console.WriteLine($"{userToyota}.txt and {userBmw}.txt and {userTesla}.txt has been created in {rootDirectory}.");
            }
        }
    }
}