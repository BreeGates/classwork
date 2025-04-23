namespace Day1StudentClassExample;

    // Internal attribute so we can use the class anywhere
    // public - anyone can use this class
    // Student - name of the class -  Classname are in PascalCase
    
    // A class is a decriptionof an object used in object oriented programming
    // A class contains data ( class memeber/class data and methods (class methods)'// A class is a programmer defined data type, the programmer is responsible for:
    //
    // the data in the class
    // class can do whatever a programmer decides it should or shont do
public class Student
{
    // Define the data for our class
    // private indicates only memebers of the class can access the dat
    // private implements the Object-Oriented principle of Encapsulation
    // Encapsulation - class should protect the data from outside access
    //                only methods in the class can acccess the data
    //
    //                Users of the class access the data using methods
    //                 defined in the class
    // Note: The data is defined without an intial value
    // Class data should be initialized in constructors
    private string studentName;
    private List<int> testScores;
    
    // Define methods for the class
    
    // One special methods for a class is called a constructor 
    // A constructor is responsible for initializing the data in a class
    // (data should never be unintialized - the data in a class - the starting value needs to be known)
    
    // a constructor method is special because:
    //
    // 1. it has no return type; not even void
    // 2. It has the same name as the class
    // 3. it may or may not recieve parameters (initializers)
    // ( a constructor with no parameters is called a default constructor)
    // 4. usually public
    
    // ( a constructor with no parameters is called a default constructor)]]// Define constructor to initailalize our data with values
    //                  specified by the user

    public Student(string studentName, List<int> testScores)
    {
        studentName = name; // Set the class data tp the data passed in from the user
        testScores = this.testScores; // Set the class data to 

    }
}