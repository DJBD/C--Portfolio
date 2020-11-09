//Reverse and exclude
//Write a program that reverses a collection and removes elements that are divisible by a given integer n.
//Use predicates/functions.

//Input:
//	1 2 3 4 5 6
//	2
//Output:
//	5 3 1
//Input:
//	20 10 40 30 60 50
//	3
//Output:
//	50 40 10 20


using System;
using System.Collections.Generic;
using System.Linq;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Please Enter a collection of numbers: ");
            string[] userinput = Console.ReadLine().Split();
            var intVals = (Array.ConvertAll(userinput, s => int.Parse(s))).ToList();
            Console.Write("Remove all numbers devisible by:  ");
            int userinput1 = int.Parse(Console.ReadLine());

            Predicate<int> divisible = n => n % userinput1 != 0;
            
            Func<List<int>, Predicate<int>, IEnumerable<int>> ReverseRemove = (x, y) =>
            {
                var v =
                    from n in x
                    where y(n)
                    select n;
                return v.Reverse();
            };

            var reverso = ReverseRemove(intVals, divisible);
            
            foreach (var item in reverso)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
