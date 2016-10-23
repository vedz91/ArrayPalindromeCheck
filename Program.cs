using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryHere
{
    class Program
    {

        static bool isPalindrome(string str)
        {
            //lowercase the complete string
            str = str.ToLower();
            var len = str.Length;
            var op = true;
            //Compare the first and the last and so on
            for (var i = 0; i < len / 2; i++)
            {
                if (str[i] != str[(len - 1) - i])
                {
                    op = false;
                    break;
                }
            }
            return op;
        }
        static void Main(string[] args)
        {
            //initialize the list
            List<string> names = new List<string>() { "Gimli", "Fili", "Ilif", "Ilmig", "Mark" };
            //Calculate the comibnatiom
            List<string> c = Combination(names, names.Count);
            Console.WriteLine("Palindrome Combinations: ");
            foreach (string s in c)
                if (isPalindrome(s))//check for palindrome
                    Console.WriteLine(s);
            Console.ReadLine();
        }

        static public List<string> Combination(List<string> pNames, int n)
        {
            if (n == 1)
                return new List<string> { pNames[0] };

            // read the last name
            string last = pNames[n - 1];

            // process 1 less element on next xycle
            List<string> interimRes = Combination(pNames, n - 1);

            // List to keep final string combinations
            List<string> finalRes = new List<string>();

            // add interinRes in Final
            if (interimRes.Count > 0)
                finalRes.AddRange(interimRes);

            // add the last name
            finalRes.Add(last);

            // create combntn with last name
            foreach (string s in interimRes)
                finalRes.Add(s + last);

            return finalRes;
        }

    }
}

