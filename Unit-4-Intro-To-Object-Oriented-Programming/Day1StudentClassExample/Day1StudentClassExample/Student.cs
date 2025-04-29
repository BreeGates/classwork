namespace Day1StudentClassExample;

    // Internal attribute so we can use the class anywhere
    // public - anyone can use this class
    // Student - name of the class -  Classname are in PascalCase
    
    // A class is a decriptionof an object used in object oriented programming
    // A class contains data ( class memeber/class data and methods (class methods)'// A class is a programmer defined data type, the programmer is responsible for:
    //
    // the data in the class
    // class can do whatever a programmer decides it should or shont do
// Because it is a programmer defined data type, the programmer is responsible for:
//
// the data in the class
// the methods that manipulate the class
    public class Student
    {
        // Define the data for our class
        // private indicates only members of the class can access the data
        // private implements the Object-Oriented principle of Encapsulation
        //

        // Encapsulation - class should protect the data from outside access
        //                only methods in the class can acccess the data (behaivors of the object)
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
        // As the class designer you decide what you need to properly intialize obejects of the class 
        // You decide how many constructors you meed or how users of the class can intialize your objects 
        //
        // Do we want to allow an obwject with default valuses?
        // Does it make sense to have a default  student name and default scores?
        // Default value is when the value is not known
        //Do we want to allow an object with default values?
        // Does it make sense to have a default student name and default scores?
        // No- dont code a default ctor to initialize with default values
        // Yes code a 0 arg ctor to assign default values : public Student
        //
        // Do we want to allow storing the student name with scores?
        // yes code a 1 arg ctor that takes the name and assigns it studentName
        //    and assigns an empty list to testScores
        // Do we want to allow storing test scores without a name?
        // no - dont code a 1 argument ctor that takes only the scores: public Student(List<int> scores)
        //
        /**********************************************************************
         * Constructors
         * ********************************************
         */
        public Student(string theName) // 1 arg ctor to accept a name only (ctor = constructor)
        {

            studentName = theName; // assign the passed to the ctor to our studentName
            testScores = new List<int>(); // Define and assign an empty List to testscore
        }




        public Student(string name, List<int> Scores) // 2 arg constructor
            //
        {
            studentName = name; // Set the class data tp the data passed in from the user
            testScores = Scores; // Set the class data to do it
        }


/**********************************************************************
 * Methods to manipulate the class
 * ******************/

        // we need a method to allow for our users to access the scores
        // Every method requires a method signature and a body
        // method signature: access return
        //                     type type MethodName(parameters)
        // Method body: inside { } following method signature
        public void AddScore(int score) // Accept a score and return nothing
        {
            testScores.Add(score);
        }

        // Allow the user to get the sum of the scores
// we need a method to add up the scores and return
        public int SumOfScores() // no args are needed as we have access to all the data we need in class
        {
            // Define a variable to hold what we are returning
            int sum = 0;

            // Two ways we can do this:
            // 1. Use a foreach loop
            // 2.See if there is method for List that do the sum for us

            //There seems to be a method but it looks complicated so we are not going to use it

            //We will use a  foreach loop
            foreach (int scores in testScores)
            {
                sum = sum + scores; // sum+= scores is ok too
            }

            // return the variable with result
            return sum;
        }

        //Method compute average score for user
        public int AvgOfScores()
        {
            return SumOfScores(); // Using a class method inside another class method
        }



        // Provide a method to display data
        public void ShowStudent()
        {


            Console.WriteLine("Name: " + studentName);
            Console.Write("Scores: ");

            foreach (int score in testScores)
            {
                Console.Write(score + " "); // Display on the same line
            }
        }
    }
