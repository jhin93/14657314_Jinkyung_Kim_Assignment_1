using System;

//Program demonstrates the use of arrays
namespace Week3Programs
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            // Declare an array of size 10
            // to store marks of 10 students
            double[] marks = new double[10];
            string userInput;
            // Initialize the marks array with user inputs
            for(int loopControlVar = 0; loopControlVar <10; loopControlVar++)
            {
                // Display message to the user
                Console.Write("Enter the mark for Student-{0}: ", loopControlVar + 1);
                // Read user input and store in a string variable
                userInput = Console.ReadLine();
                // Convert the user input from string to Double
                marks[loopControlVar] = Convert.ToDouble(userInput);
            }
            // Compute array lenght and display
            int arraySize = marks.Length;
            Console.WriteLine("\nThere are {0} elements in the marks array", arraySize);
            Console.WriteLine("\nYou have entered the folowing values:");

            // Display the values provided by the user
            for (int loopControlVar = 0; loopControlVar <10; loopControlVar++)
            {
                // Display the values
                Console.WriteLine("Mark {0} : {1}", loopControlVar + 1, marks[loopControlVar]);
            }
            // 
            Console.ReadKey();
        }
    }
}

