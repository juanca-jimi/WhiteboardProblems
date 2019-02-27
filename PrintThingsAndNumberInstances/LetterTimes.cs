using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfLettersWithTimes
{
    // The goal here is to return the characters and the number of times each character is used!
    class Program
    {
        static void Main(string[] args)
        {
            yourAnswer("Job lives in Alabama");
        }
        public static string yourAnswer(string input)
        {
            char[] characterToCount = new char[input.Length];
            int[] timesCharacterUsed = new int[input.Length];
            int unique = 0;
            // IMPLEMENT THIS CODE IF YOU ONLY WANT LETTER CHARACTERS
            // string newString = "";
            // foreach (char i in input)
            // {
            //    if (char.IsLetter(i))
            //    {
            //        newString += i;
            //    }
            // }
            input = input.ToLower();
            string newString = "";
            // We will remove spaces next
            foreach (char i in input)
            {
                if (!char.IsWhiteSpace(i)) { newString += i; }
            }
            foreach (char letter in newString)
            {
                for (int i = 0; i < unique; i++)
                {
                    if (characterToCount[i] == letter)
                    {
                        counter[i]++;
                    }
                }
            }


            

            return newString;
        }
    }
}
