using System.Xml.Schema;

namespace Day1StudentClassExample;

class Program
{

    // This is an application program
    // it instantiates and uses objects to perform processing
    // Every application has exactly one method called Main()


    static void Main(string[] args)
    {
        Console.WriteLine("Hey Bree's Here!");

        // Instantiate (define a Student class object
        // Aclass is data type
        // Define an object of a class like any other variable with a slight difference

        // data- type name = initializer; int sum = 0;
        // is intialized using one of its constructors
        // className name = new ClassName(intializers);

        List<int> scores = new List<int>();
        scores.Add(100);
        scores.Add(90);
        scores.Add(80);

        List<int> scores2 = new List<int>();
        scores2.Add(100);
        scores2.Add(90);
        // Instatiate a Student using the data we want to store in the Student object
        Student aStudent = new Student("Bree", scores);

        // Display the Student object we created
        // Console.Write
        Console.WriteLine("aStudent: " + aStudent);


        // Provide a method to display our data
        // (Console.WriteLine() doesnt know how to do it)
        {

// Define a student with no scores

            Student johnTheStudent = new Student("John");
            johnTheStudent.ShowStudent();

            //Add some scores to johnTheStudent
            johnTheStudent.AddScore(86);
            johnTheStudent.AddScore(22);
            johnTheStudent.AddScore(55);

            johnTheStudent.ShowStudent(); // Display the data in the Student Object
            johnTheStudent.AddScore(0);
            johnTheStudent.AddScore(10);

            Console.WriteLine($"\nThe sum of  scores: {johnTheStudent.SumOfScores()}");
            Console.WriteLine($"\nTheavgof scores: {johnTheStudent.AvgOfScores()}");

            //Console.WriteLine(aStudent.studentName);
        }
    }
}
