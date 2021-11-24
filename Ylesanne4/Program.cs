using System;
using System.IO;

namespace Ylesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirect = $@"C:\Users\opilane\samples\Proov";
            Console.WriteLine("Mis auto valiku soov teil on? 'toyota' 'bmw' 'tesla'");
            string userFile = Console.ReadLine();
            string fileDirect = $@"{rootdirect}\{userFile}.txt";
            bool excists = File.Exists(fileDirect);
            if (excists)
            {
                string[] dataFromFile = File.ReadAllLines(fileDirect);
                if (userFile == "toyota" || userFile == "bmw" || userFile == "tesla")
                {
                    foreach (string line in dataFromFile)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine($"{userFile}.txt Ei eksisteeri.");
                }
            }
            else
            {
                Console.WriteLine($"{userFile}.txt Ei eksisteeri");

        
            }
        }
    }
}

