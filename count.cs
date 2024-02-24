using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Sentence:");
            string inputString = Console.ReadLine();

            string[] words = inputString.Split(' ');

            int num_words = words.Length;

            Console.WriteLine($"{num_words}");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }


        }
    }
}
