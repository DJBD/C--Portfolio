//List of Predicates
//Find all numbers in the range 1..N that are divisible by the numbers of a given sequence.
//Use predicates/functions.

//Input:
//	10
//	1 1 1 2
//Output:
//	0 2 4 6 8 10
//Input:
//	100
//	2 5 10 20
//Output:
//	0 20 40 60 80 100
//Input:
// 30
// 2 4 5
//Output:
// 




using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("1...N:  ");
            int n = int.Parse(Console.ReadLine());
            var List_n = new List<int>();
            for (int i = 1; i <= n; i++) List_n.Add(i);

            Console.Write("Sequence of numbers: ");
            string[] userinput = Console.ReadLine().Split();
            var intVals = (Array.ConvertAll(userinput, s => int.Parse(s))).Distinct().ToList();

            Func<List<int>, List<int>, List<int>> calculate = (x1, x2) =>
            {
                var New_list = new List<int>();
                foreach (var VARIABLE1 in x1)
                {
                    int sum = 0;
                    foreach (var VARIABLE2 in x2)
                    {
                        sum += VARIABLE1 % VARIABLE2;
                    }

                    if (sum == 0) New_list.Add(VARIABLE1);
                }

                return New_list;
            };
            
            
            foreach (var VARIABLE in calculate(List_n,intVals))
            {
                Console.Write($"{VARIABLE} ");
            }


        }
    }
}
