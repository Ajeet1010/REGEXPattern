using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace REGEXPractice
{
    // UC1-  Program that matches a string that has an ‘a’ followed by two to three 'b'.
    internal class StringMatch
    {
        const string Rule = "^[A-Z,a-z,0-9]{1,}[a]{1}[b]{2,3}$";
        public void FollowPattern()
        {
            string user = "^[a]{1}[b]{2,3}$";
            string[] input = { "aab", "a", "b", "abb", "abba", "aab", "aabb" };
            RegexPattern(input, user);
            Console.WriteLine("\n\n---------------------\n--------------------\n\n");


            Console.Write("Enter the string:  ");
            string match = Console.ReadLine();
            if (Regex.IsMatch(match, Rule))
                Console.WriteLine("\nEntered string is:  {0}\nString is valid", match);
            else
                Console.WriteLine("\nString is invalid.\nEnter correct string in the format has an ‘a’ followed by two to three 'b'");

            
        }

        
        public static void RegexPattern(string[] input, string user)
        {
            foreach (string entered in input)
            {
                if (Regex.IsMatch(entered, user))
                    Console.WriteLine("{0} string is valid", entered);
                else
                    Console.WriteLine("{0} string is invalid", entered);
            }
        }
    }
}
