using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEmail
{
    class RetrieveEmail
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getPossibleEmail("  sddnfbsjdbkjdf   sjdfhkjsdbk      snuifnod@sndflskd   "));
        }
        public static string getPossibleEmail(string input)
        {
            string finalString = "";
            int index = input.IndexOf('@');
            int firstIndex = 0;
            int lastIndex = input.Length - 1;
            for (int i = index; i >= 0; i--)
            {
                if (input[i] == ' ')
                {
                    firstIndex = i + 1;
                    break;
                }
            }
            for (int i = index; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    lastIndex = i - 1;
                    break;
                }
            }
            for (int i = firstIndex; i <= lastIndex; i++)
            {
                finalString += input[i];
            }
            return finalString;
        }
    }
}
