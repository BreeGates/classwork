using System;
using System.Collections.Generic;

namespace WordProcessingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Split a sentence into words");
                Console.WriteLine("2. Collect strings into a list");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1/2/3): ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        RunSentenceSplitter();
                        break;
                    case "2":
                        RunWordCollector();
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void RunSentenceSplitter()
        {
            string choice;
            do
            {
                
            } while (expression);
            {
                Console.Write("Enter a sentence: ");
                string sentence = Console.ReadLine();
                string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }

                Console.Write("Would you like to continue (y/n)? ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }

        static void RunWordCollector()
        {
            List<string> collected = new List<string>();
            string choice;
            do
            {
            {
                Console.Write("Enter some text: ");
                string text = Console.ReadLine();
                collected.Add(text);

                Console.Write("You have entered: ");
                Console.WriteLine(string.Join(" ", collected));

                Console.Write("Would you like to continue (y/n)? ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");

            Console.WriteLine("Goodbye!");
        }
    }
}