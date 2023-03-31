using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace REGEXPractice
{
    // UC2-  Program to find sequences of lowercase letters joined by an underscore.
    internal class LowerCase
    {
        public void Underscore()
        {
            string user = "^[a-z]+_[a-z]{1,}$";
            string[] input = { "aa_b", "a_a", "b_s", "ab_b", "ab_ba", "a_abA", "a_abLb" };
            RegexPattern(input, user);                   
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
