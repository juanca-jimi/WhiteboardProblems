using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAnnagram
{
    class IsAnnagram
    {
        //Do they contain the same letters not necesarrily in the same order

        //TODO: Implement unit test
        static void Main(string[] args)
        {
        }
        public static string[] getStringsToCheck(int numbOfStrings)
        {
            string[] yourStrings = new string[numbOfStrings];
            for (int i = 1; i <= numbOfStrings ; i++ )
            {
                Console.WriteLine("Enter your {i} string");
                yourStrings[i] = Console.ReadLine();
            }
            return yourStrings;
        }
        public static bool isAnnagram(string[] yourStrings)
        {
            bool annagram = true;
            string[] yourNewStrings = new string[yourStrings.Length];
            for (int i = 0; i < yourStrings.Length; i++)
            {
                 //TODO: sort each string in string Array
            }
            for (int i = 0; i < yourStrings.Length-1; i++)
            {
                if (yourStrings[i] == yourStrings[i + 1])
                {
                    continue;
                }
                else return false;
            }
            return annagram;
        }
    }
}
