/*Knights of Honour
Write a program that reads a collection of names as strings from the console and then appends "Sir" in front of every name and prints it back onto the console.
Use Action<T>.

Input: 
Fred Betty John
Joan
Output:
Sir Fred
Sir Betty
Sir John
Sir Joan*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sir_collection = Console.ReadLine()?.Split().ToList();

            Action<List<string>> sirprint = (arg1) =>
            {
                arg1 = arg1.ToList();
                
                for (int i = 0; i < sir_collection.Count; i++) //cannot use ForEach here as it will not "append" to the original list
                {
                    arg1[i] = "Sir " + arg1[i];
                    Console.WriteLine(arg1[i]);
                }
            };

            sirprint(sir_collection);
        }
    }
}