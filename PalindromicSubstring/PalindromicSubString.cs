using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromicSubstring
{
    // A solution to find how many substrings are in a given string
    //TODO: Write unit test
    //On LeetCode passed 128 out of 130 test but exceeded time limit due to extreme cases
    class PalindromicSubString
    {
        static void Main(string[] args)
        {
        }
        public int CountSubstrings(string s)
        {
            int count = s.Length; 
            // counts the number of characters because each character is a palindrome
            for (int i = 0; i < s.Length - 1; i++)
            {
                //Starts at the first index of the string
                for (int j = i + 1; j < s.Length; j++)
                {
                    // nests each following index of the  string and checks
                    if (s[i] == s[j])
                        //If the index is the same character
                    {
                        //When it is we'll put the string into tempString 
                        //and the reversed string into checkString
                        string tempString = "";
                        string checkString = "";
                        for (int t = i; t <= j; t++)
                        {
                            tempString += s[t];
                        }
                        for (int c = j; c >= i; c--)
                        {
                            checkString += s[c];
                        }
                        if (checkString == tempString)
                            //If they're equal then its a palindrome... COUNT IT
                        {
                            count++;
                        }
                    }
                }

            }
            return count;
        }
    }
}
