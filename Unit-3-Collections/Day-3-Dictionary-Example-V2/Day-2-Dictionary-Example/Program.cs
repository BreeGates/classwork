using System;
using System.Collections.Generic;
using System.ComponentModel.Design; // Give me access to the systems generic collections stuff

namespace Day_2_Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************
             * Example use of a Dictionary with array/List value
             *********************************************************/

            // Ask the user for a name and a grade
            // Store them in a Dictionary

            // Dictionary to hold name (key) and grade (value)
            //         key     value
            //         type    type    name      = new Dictionary<key-type, value>();
            Dictionary<string, double> gradeBook = new Dictionary<string, double>();

            // Lets add students and grades until the user indicates they are done
            // Loop until the user satisfies the condition instead of a specific number of times
            // Replace the for loop with either a while-loop or do while()
            // Do we want to loop at least once? Yes do while
            //Is ok to loop 0-times? Yes - do while loop No - while-loop
            //
            // In this case we have to ask the user at least once to enter  some data
            // How do we want the user to let us know they are done?
            // Create an on/off switch
            // Prompt - ask if they are done
            // Set a condition based on what they tell us
            string userResponse = "";
            do
            {

// Ask the user for the student name and grade
                Console.Write("Are you done? (y/n)");
                //Get a response from the user and convert
                if (userResponse != "y") ;
                userResponse = Console.ReadLine().ToLower();
                Console.Write("Enter grade: ");
                // We can use a try/catch to handle the exception
                // When the user enters a non numeric grade causing N EXCEPTION
                // 1. Ignore it and keep going - we are doing this
                // 2. Give them another chance to enter it
                // 3. Set the grade to 0

                //We need to define grade outside any block so it can be used by all code
                double grade = 0;

                try // a statement inside this try block might cause an exception
                {
                    // Get the user input as a string in case we need it later
                    userGrade = Console.ReadLine(); 
                    grade = Double.Parse(UserGrade()); // Get student grade
                }
                catch (FormatException exceptionObject) // if it throws a FormatException...

                {
                    Console.WriteLine("The data you entered )(" + grade + ");
                    Console.WriteLine("The data is ignored");
                    //Skip adding student to the dictionary ( skip the rest of the loop process
                    continue; // skip the rest of the loop processing
                    
                } 

                {
                    Console.WriteLine("");
                    throw;
                }
                double grade = Double.Parse(Console.ReadLine()); // Get student grade

                // Add the data to our Dictionary
                // Dictionary[key}     = value;
                gradeBook[studentName] = grade; // gradeBook.Add(studentName, grade) // may cause an exception
            } while (userResponse != "n");

            // Display the entrys in our Dictionary
            // Use a KeyValuePair type to get an entry from teh Dictionary
            //Get a response from the user and convert
            if userResponse != "y" userResponse != "n";
            {
                Console.WriteLine("Sorry we only accept 'y' or 'n'.");
                userResponse = Console.ReadLine().ToLower();
            }
            else
            {
                Console.WriteLine("Are you done? (y/n)");
                //Get a response from the user and convert to lowercase
                userResponse = Console.ReadLine().ToLower();
                // We are checking userResponse AFTER we get it from the whil

                Console.Write("Enter grade: ");
                double grade = Double.Parse(Console.ReadLine()); // Get student grade

                // Add the data to our Dictionary
                // Dictionary[key}     = value;
                gradeBook[studentName] = grade; // gradeBook.Add(studentName, grade) // may cause an exception
            }

            // Display the entrys in our Dictionary
            // Use a KeyValuePair type to get an entry from teh Dictionary

            foreach (KeyValuePair<string, double> anEntry in gradeBook)
            {
                Console.WriteLine(anEntry.Key + " has a grade of " + anEntry.Value);
            }

            Console.WriteLine("Please press enter to end program...");
            Console.Read();
        }
    }
}
