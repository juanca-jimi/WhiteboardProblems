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
            string cleanPhrase = "";
            string check = "";
            for (int i = 0; i < phrase.Length; i++)
            {
                if (isAlphaNumericChar(phrase[i]))
                {
                    cleanPhrase += phrase[i];
                }
            }
            for (int i = cleanPhrase.Length-1; i >=0; i--)
            {
                check += cleanPhrase[i];
            }
            return (cleanPhrase==check) ?true:false;
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
