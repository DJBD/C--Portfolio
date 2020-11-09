//Custom Comparator
//Write a custom comparator that sorts all even numbers before all odd ones in ascending order.Pass it to an Array.sort() function and print the result.

//Input:
//	1 2 3 4 5 6
//Output:
//	2 4 6 1 3 5
//Input:
//	-3 2
//Output:
//	2 -3

using System;
using System.Collections;
using System.Collections.Generic;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please Enter a collection of numbers: ");
            string[] userinput = Console.ReadLine().Split();
            var intVals = (Array.ConvertAll(userinput, s => int.Parse(s)));

            Array.Sort(intVals,customsorter.sortOddEven());
            
            foreach (var VARIABLE in intVals)
            {
                Console.Write(VARIABLE + " ");
            }
        }
    }

}

public class customsorter : IComparable
{
    private class sortOddEvenHelper : IComparer
    {
        int IComparer.Compare(object a, object b)
        {
            int n1 = (int) a;
            int n2 = (int) b;
            if (n1 % 2 == 0 && n2 % 2 ==0)
            {
                if (n1 > n2)
                    return 1;
                if (n1 < n2)
                    return -1;
                else
                    return 0;
            }
            
            if (n1 % 2 != 0 && n2 % 2 !=0)
            {
                if (n1 > n2)
                    return 1;
                if (n1 < n2)
                    return -1;
                else
                    return 0;
            }

            if (n1 % 2 != 0 && n2 % 2 == 0)
            {
                return 1;
            }

            if (n1 % 2 == 0 && n2 % 2 != 0)
            {
                return -1;
            }

            else return 0;
        }
    }
    public static IComparer sortOddEven()
    {      
        return (IComparer) new sortOddEvenHelper();
    }

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
}


