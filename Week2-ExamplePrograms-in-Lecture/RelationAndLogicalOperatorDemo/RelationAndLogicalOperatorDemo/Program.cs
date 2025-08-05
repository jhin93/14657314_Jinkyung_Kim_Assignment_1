using System;
/* The Program shows a demo on Relational 
   and Logical Operator usage
    
    Problem: Check whether a number is even  
             and if it is greater than 10
*/
namespace Week2Programs
{
    class RelationAndLogicalOperatorDemo
    {        
        static void Main(string[] args)
        {
            // Variable Declaration
            int numToCheck = 12;

            // Check for even and odd
            if((numToCheck % 2) == 0 && numToCheck > 10)
            {
                Console.WriteLine("The number is even and greater than 10");
            }
            else
            {
                Console.WriteLine("The number is ether not even or not greater than 10");
            }
            Console.Read();
        }
    }
}


