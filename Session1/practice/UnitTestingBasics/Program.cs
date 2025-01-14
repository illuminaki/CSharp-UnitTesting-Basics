using System; // Importing the System namespace which contains fundamental classes and base classes.

namespace UnitTestingBasics // Declaring a namespace to organize the code.
{
    class Program // Defining the Program class, which contains the entry point of the application.
    {
        static void Main(string[] args) // Main method: the starting point of the program execution.
        {
            var calculator = new Calculator(); // Creating an instance of the Calculator class.
            
            // Calling the Add method of the Calculator instance to add two numbers (2 and 3).
            int sum = calculator.Add(2, 3); 
            
            // Outputting the result to the console in a formatted string.
            Console.WriteLine($"The sum of 2 and 3 is: {sum}");
        }
    }
}

