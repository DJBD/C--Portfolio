//Predicate for names
//Write a program that filters a list of names according to their length.On the first line you will be given integer n representing name length. On the second line you will be given some names as strings separated by space. Write a function that prints only the names whose length is less than or equal to n.

//Input:
//	4
//	Kurnelia Qnaki Geo Muk Ivan
//Output:
//	Geo
//	Muk
//	Ivan
//Input:
//	4
//	Karaman Asen Kiril Yordan
//Output:
//	Asen

using System;
using System.Collections.Generic;
using System.Linq;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name length:  ");
            int lengthofName = int.Parse(Console.ReadLine());

            Console.Write("Please Enter a collection of Names: ");
            string[] names = Console.ReadLine().Split();

            Predicate<string> namelessthan = n => n.Length <= lengthofName; //can I make these work for more generic purposes?

            Func<string[], Predicate<string>, IEnumerable<string>> predicatePrint = (x, y) =>
            {
                var L = 
                    from n in x 
                    where y(n)
                    select n;
                return L;
            };

            foreach (var name in predicatePrint(names, namelessthan))
            {
                Console.WriteLine(name);
            }
        }
    }
}
