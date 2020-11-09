//Find Evens or Odds
//You are given a lower and an upper bound for a range of integer numbers.Then a command specifies if you need to list all the even or odd numbers in the given range.
//Use Predicate<T>.

using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userinput = Console.ReadLine()?.Split();
            int[] intVals = Array.ConvertAll(userinput, s => int.Parse(s));
            var oddOreven = Console.ReadLine();


            Predicate<int> numEve = n => n % 2 == 0;
            Predicate<string> strEve = s => s.Equals("even");

           for (int i = intVals[0]; i <= intVals[1]; i++)
           {
                if (strEve(oddOreven) && numEve(i)) Console.Write($"{i}  ");
                else if ((!strEve(oddOreven) && !numEve(i))) Console.Write($"{i}  ");
           }

        }

    }
}
