using System;
// Program to demonstrate the paramenter
// passing by reference

namespace Week2Program
{
    class ReferenceParameterDemo
    {
        // Create a method to swap the values of two variables.
        public void SwapNumbers(ref int  num1,  ref int num2)
        {
            // Declare a temporary variable 
            int temp;

            // Swap the values
            temp = num1; // Store the value of num1 in temp variable
            num1 = num2; // Store the value of num2 in num1
            num2 = temp; // Pass the value of temp to num2

            // Display the number After Swaping
            Console.WriteLine("\nInside Swap():");
            Console.WriteLine("After Swaping: number1 = {0}", num1);
            Console.WriteLine("Before Swaping: number2 = {0}", num2);
        }

        static void Main(string[] args)
        {
            //Create an instance of class ReferenceParameterDemo
            ReferenceParameterDemo swap = new ReferenceParameterDemo();

            // Variable declaration
            int number1 = 10, number2 = 20;

            // Display the number before Swaping
            Console.WriteLine("\nInside Main():");
            Console.WriteLine("Before Swaping: number1 = {0}", number1);
            Console.WriteLine("Before Swaping: number2 = {0}", number2);

            // Call the swap method and pass number1 and number2
            swap.SwapNumbers(ref number1, ref number2);

            // Display the number After Swaping
            Console.WriteLine("\nInside Main():");
            Console.WriteLine("After Swaping: number1 = {0}", number1);
            Console.WriteLine("After Swaping: number2 = {0}", number2);

            // Accept a key press from user
            Console.ReadKey();
        }        
    }
}

