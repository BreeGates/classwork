using System.Xml.Schema;

namespace Day1StudentClassExample;

class Program
{
    
    // This is an application program
    // it instantiates and uses objects to perform processing
    // Everey application has exactly one method called Main()
    
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hey Bree's Here!");
        
        // Instantiate (define a Student class object
        // Aclass is data type
        // Define an object of a class like any other variable with a slight difference
        
        // data- type name = initializer; int sum = 0;
        // is intialized using one of its constructors
        // className name = new ClassName(intializers);

        List <int> scores = new List<int>();
            scores.Add(100);
            scores.Add(90);
            scores.Add(80);
        
        // Instatiate a Student using the data we want to store in the Student object
        Student aStudent = new Student("Bree", scores);

        // Display the Student object we created
        // Console.Write
        Console.WriteLine("aStudent: " + aStudent);
    }
    
    // Provide a method to display our data
    // (Console.WriteLine() doesnt know how to do it)
    public void ShowStudent()
    {
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Scores: " + studentScores);

        Console.WriteLine(aStudent.studentName);
    }
}
