namespace Day_2_For_Each_Example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to an Example of a For-Each Loop");
        // Ask the user to enter a sentence(series of words seperated by whitespace - space, tab, something you cant see)
        // Display each word in the sentence
        // for loop vs for each
        //
        // both can process an array or list from beginning to end
        //for- loop can start and end at any element by setting int i= and changing the condition
        // for each always processes from the beginning to end
        // for loop you know which elements your processing by using the value in i
        // for each loop you do not know what element number youre processing
        // Note. to add
        // .count (for a list) >length (for an array)
        // list is less efficient than an array
        Console.WriteLine("Please enter a sentence:");
        string[] splitSentence = sentence.Split(" ");  // split the sentence into words
        
        //Display all the words using a do-while loop
        //
        // do
        // {
        // loop processing
        // } while(condition) // loop while condition is true
        //
        //  we always do the loop processing atleast once
        // because the condition is checked at the end of the loop process

        int currentElementNumber = ++; // increment our index variable to move through the array or list

        do
        {
            Console.WriteLine();
        } while (currentElementNumber < splitSentence.Length);
        {
           
        }
        
    }
}