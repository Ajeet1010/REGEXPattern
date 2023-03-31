using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;

namespace REGEXPractice
{
    // UC5-  Program to find valid file names with an valid file type extension.
    internal class Valid
    {
        const string extns = "^[A-Z,a-z,0-9]{1,}(.jpg|.pdf|.jpeg)+$";
        public void Filename()
        {
            string extnsn = "^[A-Z,a-z,0-9]{1,}(.jpg|.pdf|.jpeg)+$";
            string[] input = { "abc.jpeg", "abc.jpg", "KIL.pg", "juj.pdf", "jik.12", "aabA", "aabLb" };
            RegexPattern(input, extnsn);
            Console.WriteLine("\n\n---------------------\n--------------------\n\n");


            Console.Write("Save file as:  ");
            string format = Console.ReadLine();
            if (Regex.IsMatch(format, extns))
                Console.WriteLine("\nEntered file extension is:  {0}\nFile extension is valid", format);
            else
                Console.WriteLine("\nFile extension is invalid.\nEnter correct format for file type");
        }
        
        public static void RegexPattern(string[] input, string extnsn)
        {
            foreach (string entered in input)
            {
                if (Regex.IsMatch(entered, extnsn))
                    Console.WriteLine("{0} Extension is valid", entered);
                else
                    Console.WriteLine("{0} Extension is invalid", entered);
            }
        }
    }
}
