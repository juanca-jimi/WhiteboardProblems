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
            Console.Write(revString("What are your goals?"));
        }
        public static string revString(string input)
        {
            string finalString = "";
            for (int i = input.Length - 1; i > -1; i--)
            {
                finalString += input[i];
            }
            return finalString;
        }
    }
}
