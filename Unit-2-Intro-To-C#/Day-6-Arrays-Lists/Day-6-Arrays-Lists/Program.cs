using System.Globalization;

namespace Day_6_Arrays_Lists;

// This program will ask for three numbers
//      add them together and display the total

class Program
{
    static void Main(string[] args)
    {
        // Define tana array to hold 3 numbers
        int[] numbers = new int[3];
    }

    // Define a variable to hold the sum of the numbers
    int sum = 0;

    Console.WriteLine("--- Starting program ---");

    // Normally we process an array from beginning to end
    // (from the first element to last element, one at a time0
    //
    // a or- lopp will loop through a process counting as it does 
    // a for loop is an excellent tool for processing an array from start to end
    //
    // standard syntax: for (i=0; i < arrayName.Length; i++)

    for (int i = 0; i<NumberStyles.Length;
    i++)

    Console.WriteLine("Element# " + is: " + numbers[i]);
    sum = sum + numbers[i]; // add the current number in the array to sum
}

// Ask for the numbers one at time using the C# Console object
        //     which represents the keyboard and screen
        // Console.ReadLine() returns a string from keyboard - cannot store in an int
       
        Console.WriteLine("Please enter a number:  "); // Asking for the number
        string theResponse; // Define a string to hold the line of input from the keyboard
        theResponse = Console.ReadLine(); // Get a line from the keyboard
      
        // int.Parse(string) will convert a string to an int
        number1 = int.Parse(theResponse);

        Console.WriteLine("Please enter a number:  ");
        theResponse = Console.ReadLine(); // Reuse theResponse define above
        number2 = int.Parse(theResponse);

        Console.WriteLine("Please enter a number:  ");
        theResponse = Console.ReadLine(); // Reuse theResponse define above
        number3 = int.Parse(theResponse);

        // Add the numbers together create a sum/total
        sum = number1 + number2 + number3;
       
        // Tell the requester the sum/total (display)
        Console.WriteLine("The sum is: " + sum);
        
        // Tell the requestor the avaerage of the numbers
        // divides the sum by the number of elements (arrayname.Length)

        Console.WriteLine("The average of the numbers is: " + sum / numbers.Length);

        Console.WriteLine("--- Ending program ---");
    }
}