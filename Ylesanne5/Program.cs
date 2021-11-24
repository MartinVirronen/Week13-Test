using System;
using System.IO;

namespace Ylesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Facts So Interesting You'll Say, OMG!");
            Console.WriteLine("How many facts do you want to see?");
            int usernumber = Convert.ToInt32(Console.ReadLine());

            GetJokes(usernumber);
        }
        private static void GetJokes(int Factsnumber)
        {
            string filepath = @"C:\Users\opilane\samples\Proov\funfacts.txt";
            string[] funfacts = File.ReadAllLines(filepath);

            if (Factsnumber > funfacts.Length)
            {
                Factsnumber = funfacts.Length;
            }


            for (int i = 0; i < Factsnumber; i++)
            {
                Console.WriteLine(funfacts[i]);

            }
        }
    }
}