/*
 Question 1
 Action Print
Write a program that reads a collection of strings from the console and then prints them onto the console. Each name should be printed on a new line.
Use Action<T>.

Input: 
	One Two Three
Output: 
	One
	Two
	Three
*/
using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = Console.ReadLine()?.Split();

            Action<Array> print = (arg1) =>
            {
                foreach (var item in arg1) Console.WriteLine(item);
            };
            
            print(collection);
        }
    }
}
