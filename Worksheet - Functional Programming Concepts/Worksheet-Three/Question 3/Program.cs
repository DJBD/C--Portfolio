/*Custom Min Function
Write a simple program that reads from the console a set of numbers and prints back onto the console the smallest number from the collection.
Use Func<T, T>.

Input:
12 4 3 2 1 7 13
Output:
1*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {

            var userinput = Console.ReadLine()?.Split();
            var intVals = Array.ConvertAll(userinput, s => int.Parse(s));

            Func<int[], int> min = (arg1) => arg1.Min();
            
            // {
            //     var min = arg1[0];
            //     foreach (int item in arg1)
            //     {
            //         if (item < min) min = item;
            //     }
            //     return min;
            // };

            Console.WriteLine(min(intVals));
        }
    }
}
