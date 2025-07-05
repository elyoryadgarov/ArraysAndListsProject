using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.ForEach(numbers, Console.WriteLine);
            
            /* Create a list of type int
             * Name the list "evens"
             */
            List<int> evens=new List<int>();

            
            /* Create another list of type int
             * Name the list "odds"
             */List<int> odds=new List<int>();
            

             /* Using either a foreach or for loop,
             * iterate through the array you populated with 10 numbers.
             * Inside the scope of the loop,
             * check to see if each number in the array is even or odd.
             * If the number is even, add it to the evens list.
             * If the number is odd, add it to the odds list.
             */
             foreach (var nums in numbers)
             {
                 if (nums % 2 == 0)
                 {
                     evens.Add(nums);
                 }
                 else
                 {
                     odds.Add(nums);
                 }
             }
                
             /* Using a foreach loop,
             * display the numbers in your "evens" list
             */
            evens.ForEach(Console.WriteLine);

            /* Using a for loop,
             * display the numbers in your "odds" list
             */
            for (var i = 0; i < odds.Count; i++)
            {
                Console.WriteLine(odds[i]);
            }
        }
    }
}
