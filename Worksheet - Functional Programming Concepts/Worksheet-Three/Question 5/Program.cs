//Applied arithmetic
//Write a program that executes some mathematical operations on a given collection.On the first line you are given a list of numbers. On the next lines you are passed different commands that you need to apply to all numbers in the list:

//"add" -> add 1 to each number;
//"multiply" -> multiply each number by 2;
//"subtract" -> subtract 1 from each number;
//"print" -> print the collection.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {     
            Func<int, int> addz = (x) => x + 1;
            Func<int, int> multi = (x) => x * 2;
            Func<int, int> sub = (x) => x - 1;
            Action<IEnumerable> print = (arg1) =>
            {
                foreach (var item in arg1) Console.Write($"{item} ");
            };

            Console.Write("Please Enter a collection of numbers: ");
            string[] userinput = Console.ReadLine().Split();
            int[] intVals = Array.ConvertAll(userinput, s => int.Parse(s));


            Console.WriteLine("Enter your commands");
            string input = string.Empty;
            IEnumerable<int> nums = intVals; //can I do without making initialising new list? Mutating orginial inVals?

            while (!input.Trim().Equals("end"))
            {
                input = Console.ReadLine();
                if (input.Trim().Equals("add")) nums = nums.Select(addz);
                if (input.Trim().Equals("subtract")) nums = nums.Select(sub);
                if (input.Trim().Equals("multiply")) nums = nums.Select(multi);
                if (input.Equals("print"))
                {
                    print(nums);
                    Console.WriteLine();
                }
            }
            print(nums);
        }
    }
    }




