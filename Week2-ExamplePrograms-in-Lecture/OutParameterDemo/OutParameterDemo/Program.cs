using System;
// Program demonstrates out parameters

namespace Week3Program
{
    class OutParameterDemo
    {
        // Create a method to accept User Input about student 
        // using out parameters
        public void UserInput(out int roll, out int mark, out string name)
        {
            // Declare a temporary variable to accept user input
            string tempUserInput;

            // Accept Student name from user
            Console.Write("Enter the Student's name: ");
            name = Console.ReadLine();

            // Accept Students roll from user
            Console.Write("Enter the Student's Roll: ");
            tempUserInput = Console.ReadLine();
            roll = Convert.ToInt32(tempUserInput);

            // Accept Students roll from the user
            Console.Write("Enter the Student's mark: ");
            tempUserInput = Console.ReadLine();
            mark = Convert.ToInt32(tempUserInput);
        }

        static void Main(string[] args)
        {
            // Variable declaration
            int roll, mark;
            string studentName;

            // Create an instance of OutParameterDemo to use the UserInput method
            OutParameterDemo studentData = new OutParameterDemo();
            // Call the user Input method and pass the variables
            studentData.UserInput(out roll, out mark, out studentName);

            // Display the values recieved from the UserInput method
            Console.WriteLine("\nThe student information received was:");
            Console.WriteLine("Student Name: {0}, \nroll: {1}, \nmark: {2}", studentName, roll, mark);
            
            //Accept a key input from user
            Console.ReadKey();
        }
    }
}


