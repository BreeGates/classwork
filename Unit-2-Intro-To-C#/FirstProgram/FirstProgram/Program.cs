namespace FirstProgram;

// This program will ask for three numbers
//  add them together and display the total

// Programming Solution - Human thinking
// Identify the detailed steps
// Write down each number as its given
// Add the numbers together
// Tell the requestor the total (display)
//
// Now that we have the steps in our solution
// Identify any data/processes you need for the steps
// 
// 1. A place to write down each number
// 2. A place to hold the sum/total
// 3. A way to ask for the numbers

class Program
{
    static void Main(string[] args)
    {
        //Define the variables to hold the numbers we need to add
        int number1 = 0;
        int number2 = 0;
        int number3 = 0;
        
        // Define a variable to hold the sum of the numbers
        int sum = 0;
        
        Console.WriteLine("--- Starting program ---");

        // Ask for the numbers at one time using the C# Console object
        // which represents the keyboard and screen
        Console.WriteLine("Please enter a number: "); // Asking for the number
        string aLine; // String to hold the line of input from the keyboard
        aLine = Console.ReadLine();   // Get a line from the keyboard
        // We need an int value to stor our numbers
        // Console.ReadLine() only returns a string
        // So we need to convert the string from Console.ReadLine() to an int
        // int. Pasrse (string) will convert a string to an int
        number1 = int.Parse(aLine);
        
        
        Console.WriteLine("--- Ending Program ---");
    }
}