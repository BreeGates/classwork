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
// 1. A place to write down each number - a variable in a program
// 2. A place to hold the sum/total -a variable in a program
// 3. A way to ask for the numbers- a method in a program (object.method ())

class Program
{
    static void Main(string[] args)
    {
        //Define the variables to hold the numbers we need to add
        int number1 = 0; // Since we will be doing math it needs to be numeric
        int number2 = 0;// Since we will be doing math it needs to be numeric
        int number3 = 0;
        
        // Define a variable to hold the sum of the numbers
        int sum = 0;
        
        Console.WriteLine("--- Starting program ---");

        // Ask for the numbers at one time using the C# Console object
        // which represents the keyboard and screen
        Console.WriteLine("Please enter a number: "); // Asking for the number
        string theResponse;   // Define the string to hold the line of input from the keyboard
        theResponse = Console.ReadLine();   // Get a line from the keyboard
        // We need an int value to store our numbers
        // Console.ReadLine() only returns a string
        // So we need to convert the string from Console.ReadLine() to an int
        // int. Pasrse (string) will convert a string to an int
        number1 = int.Parse(theResponse);
        theResponse = Console.ReadLine(); 
        
        Console.WriteLine("Please enter a number: ");
        theResponse = Console.ReadLine();
        number2 = int.Parse(theResponse);

        Console.WriteLine("Please enter a number: ");
        theResponse = Console.ReadLine(); // Reuse theResponse define above
        number3 = int.Parse(theResponse);
        
        // Add the numbers together create a sum/total
        sum = number1 + number2 + number3;
        //Alternate coding method - Choose the coding style that you like
        // However you code as long as you get the right solution
        // and you understand it, its right
        //sum =sum + number1;
        // sum = sum + number2;
        // sum = sum + number3;
        
        // Tell the requester what the sum/ total (display)
        Console.WriteLine("The sum is: " + sum); // Console is the computer and WriteLine is the display

        // Just to verify we are getting data from the keyboard
        // Lets display it
        // '+' with a string it concatentates the strings (sticks them together)
        Console.WriteLine("YOU ENTERED: " + number1);
        
        Console.WriteLine("--- Ending Program ---");
    }
}