using System;
// Program to demostrate user defined methods

namespace Week2Program
{
    class MethodDemo
    {
        static void Main(string[] args)
        {
            // Variable declaration
            int numToCheck;
            string userInput;
            bool result;
            // Accept input from user
            Console.Write("Enter an integer: ");
            userInput = Console.ReadLine();
            numToCheck = Convert.ToInt32(userInput);

            // Check for Even by passing the userinput to the IsEven() method
            result = IsEven(numToCheck);

            // Check is the result is true ot false
            if (result)
                Console.WriteLine("\nThe Number is Even!");
            else
                Console.WriteLine("\nThe Number is not Even!");

            //Accept a key press from user.
            Console.ReadKey();
        }

        // Create a new method checks whether a number is even
        static bool IsEven(int numberToCheck)
        {
            // Check if the number is even
            if (numberToCheck % 2 == 0)
                // Return true if it is even
                return true;
            else
                // Return false if it is not even
                return false;
        }
    }
}

