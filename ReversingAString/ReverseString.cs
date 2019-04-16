using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingAString
{
    public class ReverseString
    {
        static void Main(string[] args)
        {
            //Test case.. Should return LQS
            Console.Write(revString("SQL")); // LQS
            Console.ReadLine();
        }

        public static string revString(string input)
        {
            //Declaring our return string
            string finalString = "";

            //Here we begin at the end of our String (char array) and go backwards up to our input[0]
            //Then we add each index to the beginning of our return string
            for (int i = input.Length - 1; i > -1; i--)
            {
                finalString += input[i];
            }

            return finalString;
        }
    }
}
