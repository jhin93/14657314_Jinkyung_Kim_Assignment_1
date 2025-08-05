using System;
// Programs demonstrate 2D array 

namespace Week2Program
{
    class TwoDArrayDemo
    {
        static void Main(string[] args)
        {
            // Declare a 2D array to store roll number and marks
            // Assume the roll number and marks are integer
            int[,] studentInfo = new int[3, 2];
            string userInput;
            // Declare a string array to store student's name
            string[] studentName = new string[3];

            //Initialize the arrays from user inputs
            for(int outerLoopRow = 0; outerLoopRow < 3; outerLoopRow++)
            {
                // Read the Student's Name
                Console.Write("Enter the student's name: ");
                studentName[outerLoopRow] = Console.ReadLine();
                for(int innerLoopCol = 0; innerLoopCol<2; innerLoopCol++)
                {
                    if (innerLoopCol == 0)
                        Console.Write("Enter the student's roll number: ");
                    else if (innerLoopCol == 1)
                        Console.Write("Enter the student's mark: ");
                    
                    // Read the student's roll and mark from user
                    userInput = Console.ReadLine();
                    studentInfo[outerLoopRow, innerLoopCol] = Convert.ToInt32(userInput);                                  
                }
            }

            // Display students details
            for (int outerLoopRow = 0; outerLoopRow < 3; outerLoopRow++)
            {
                // Display the Student's Name
                Console.WriteLine("\nYou have entered the following details:");
                Console.WriteLine("Student Name : {0}", studentName[outerLoopRow]);
                for (int innerLoopCol = 0; innerLoopCol < 2; innerLoopCol++)
                {
                    if (innerLoopCol == 0)
                        // Display roll number
                        Console.WriteLine("Roll number: {0}", studentInfo[outerLoopRow, innerLoopCol]);
                    else if (innerLoopCol == 1)
                        // Disply Mark
                        Console.WriteLine("Mark Obtained: {0} \n", studentInfo[outerLoopRow, innerLoopCol]);
                }
            }
            // Read a key from the user
            Console.ReadKey();
        }
    }
}
