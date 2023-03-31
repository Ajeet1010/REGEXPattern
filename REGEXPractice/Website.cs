using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEXPractice
{
    // UC6- Program to validate website format.
    internal class Website
    {
        const string webformat = "^(www.)*[A-Z,a-z,0-9]{1,}(.com)*$";
        public void Format()
        {
            string valid = "^(www.)*[A-Z,a-z,0-9]{1,}(.com)*$";
            string[] input = { "www.example.com", "ww.123.com", "bridhe@fs", "gotohome.com", "alibaba" };
            RegexValidation(input, valid);
            Console.WriteLine("\n\n---------------------\n--------------------\n\n");


            Console.Write("Enter website to search:  ");
            string website = Console.ReadLine();
            if (Regex.IsMatch(website, webformat))
                Console.WriteLine("\nEntered website is --->  {0}  <--- valid", website);
            else
                Console.WriteLine("\nEntered website is --->  {0}  <--- invalid.\nEnter website in correct format {1}", website, webformat);
        }

        public static void RegexValidation(string[] input, string valid)
        {
            foreach (string inputitem in input)
            {
                if (Regex.IsMatch(inputitem, valid))
                    Console.WriteLine("Website format of --->  {0}  <--- is valid", inputitem);
                else
                    Console.WriteLine("Website format of  ---> {0}  <--- is not valid.", inputitem);
            }
        }       
    }
}
