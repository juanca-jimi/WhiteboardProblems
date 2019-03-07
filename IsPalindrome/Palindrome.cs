using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    public class Palindrome
    {
        //If we disregard everything besides a alphanumeric character and not taking into consideration case


        static void Main(string[] args)
        {
        }
        public static bool isPalindrome(string phrase)
        {
            phrase = phrase.ToLower();
            string check1 = "";
            string check2 = "";
            for (int i = 0; i < phrase.Length; i++)
            {
                if (isAlphaNumericChar(phrase[i]))
                {
                    check1 += phrase[i];
                }
            }
            for (int i = check2.Length-1; i >=0; i++)
            {
                check2 += check2[i];
            }
            return (check1==check2) ?true:false;
        }

        public static bool isAlphaNumericChar(char character)
        {
            if (char.IsLetter(character) || char.IsNumber(character))
            {
                return true;
            }
            return false;
        }

    }
}
