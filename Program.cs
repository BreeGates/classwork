using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.WriteLine($"Hello {name}, do you accept the COIN FLIP CHALLENGE? (yes/no)");
        string response = Console.ReadLine().ToLower();
        
        if (response != "yes")
        {
            Console.WriteLine("You're a coward!");
            return;
        }
        
        int score = 0;
        Random rand = new Random();
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Heads or Tails? (heads/tails): ");
            string userChoice = Console.ReadLine().ToLower();
            
            int coinFlip = rand.Next(2); // 0 for heads, 1 for tails
            string result = coinFlip == 0 ? "heads" : "tails";
            
            Console.WriteLine($"The coin landed on {result}.");
            
            if (userChoice == result)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }
        
        Console.WriteLine($"{name}, your final score is: {score}/5");
        Console.WriteLine(score >= 8 ? "You Passed!" : "You Did Not Pass.");
    }
}
