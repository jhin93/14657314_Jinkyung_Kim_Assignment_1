using System;
// Program to demonstrate value parameters.
// Program to swap two numbers
namespace Week2Program
{
    class ValueParameterDemo
    {
        static void Main(string[] args)
        {
            // Variable declaration
            int number1 = 10, number2 = 20;

            // Display the number before Swaping
            Console.WriteLine("\nInside Main():");
            Console.WriteLine("Before Swaping: number1 = {0}", number1);
            Console.WriteLine("Before Swaping: number2 = {0}", number2);

            // Call the swap method and pass number1 and number2
            SwapNumbers(number1, number2);

            // Display the number After Swaping
            Console.WriteLine("\nInside Main():");
            Console.WriteLine("After Swaping: number1 = {0}", number1);
            Console.WriteLine("After Swaping: number2 = {0}", number2);
            
            // Accept a key press from user
            Console.ReadKey();
        }

        // Create a method to swap the values of two variables.
        static void SwapNumbers (int number1, int number2)
        {
            // Declare a temporary variable 
            int temp;

            // Swap the values
            temp = number1;
            number1 = number2;
            number2 = temp;

            // Display the number After Swaping
            Console.WriteLine("\nInside Swap():");
            Console.WriteLine("After Swaping: number1 = {0}", number1);
            Console.WriteLine("Before Swaping: number2 = {0}", number2);
        }

    }
}
