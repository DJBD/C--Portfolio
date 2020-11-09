/*Predicates Galore!
Fred's parents are on a vacation for the holidays and he is planning an epic party at home. 
Unfortunately, his organisational skills are next to non-existent so you are given the task to help him with the reservations.

On the first line you get a list with all the people that are coming. 
On the next lines, until you get the "Party!" command, you may be asked to double or remove all the people that apply to given criteria. 

There are three different criteria are:

Everyone that has a name starting with a given string;
Everyone that has a name ending with a given string;
Everyone that has a name with a given length.
See the examples below:

Input:
Peter Mark Steve
Remove StartsWith P
Double Length 5
Party!
Output:
Mark, Mark, Steve are going to the party!
Input:
Peter
Double StartsWith Pete
Double EndsWith eter
Party!
Output:
Peter, Peter, Peter, Peter are going to the party!*/


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Question_10
{
    public class Program
    {
        static void Main(string[]args)
        {
            
            
                Action<List<string>,Predicate<string>> remove = (x,y) =>
                {
                    for (int i = 0; i < x.Count; i++)
                    {
                        if (y(x[i])) x.Remove(x[i]);
                    }
                };
                Action<List<string>,Predicate<string>> doubl = (x,y) =>
                {
                    for (int i = 0; i < x.Count; i++)
                    {
                        if (y(x[i]))
                        {
                            x.Insert(i, x[i]);
                            i++;
                        }
                    }
                };

                var partygroup = Console.ReadLine().Split().ToList();

                Console.WriteLine("Enter your commands");
                string input = string.Empty;
                
                while (!input.Trim().Equals("Party!"))
                {
                    input = Console.ReadLine();
                    var comands = input.Split();
                    Action<List<string>,Predicate<string>> action = remove;
                    
                    string match = comands[2];
                    Predicate<string> start = x => x.StartsWith(match);
                    Predicate<string> ends = x => x.EndsWith(match);
                    Predicate<string> len = x => x.Length == int.Parse(match);
                    Predicate<string> condtion = start;
                    
                    if (comands[0].Trim().Equals("Remove")) action = remove;
                    if (comands[0].Trim().Equals("Double")) action = doubl;
                    
                    if (comands[1].Trim().Equals("StartsWith")) condtion = start;
                    if (comands[1].Trim().Equals("EndsWith")) condtion = ends;
                    if (comands[1].Trim().Equals("Length")) condtion = len;

                    action(partygroup, condtion);
                    
                    foreach (var VARIABLE in partygroup)
                    {
                        Console.Write($"{VARIABLE} ");
                    }

                    Console.WriteLine();

                }
        }
    }
}