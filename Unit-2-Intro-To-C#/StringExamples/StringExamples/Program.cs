using System.ComponentModel.Design;

namespace StringExamples;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        /***************************************************************
         * Strings in C# are a special data type - they dont work like you think they should
         *
         * String literals are enclosed in " "
         *
         * A literal is something that says what it is: 1 1.24 "Bob"
         * string varaibles sometimes require special processing
         *    you cant use <> to compare strings
         *    Beware; Early versions of C# do not allow use of ++ with strings
         *
         * C# provides several methods to operate on strings:
         *
         *  .Equals(string) - compare the string to the left of the . to string inside () for equality
         * .CompareTo(string) - return a number indicating how the first string relates to the second
         *          return a negative number if first string is less than the second
         *        return a zero if first string is equal to the second
         *      return a positive number if first string is greater than second
         * *****************************************************************
         */
        // if (condition) {
        // What to do if condition is false
        // }
        
        string string1 = "a";
        string string2 = "b";
        
        Console.WriteLine("string1 is: " +string1);
        Console.WriteLine("string2 is: "+string2);
                
        if (string1.CompareTo(string2) > 0)  // if these are equals
        
        {
            Console.WriteLine("string1 is greater than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT greater than string2");
            {

            }
        }
    } // End of Main ()
} // End of class Program