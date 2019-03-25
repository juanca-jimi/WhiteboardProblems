using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeaserCipher
{
    class Cipher
    {
        //TODO: fix bug
        //TODO: Write unit test
        static void Main(string[] args)
        {

            string yourKey = encryptString("zoo", 25);
            Console.WriteLine(yourKey);
            Console.WriteLine(decryptString(yourKey, 25));
        }
        public static string encryptString(string input, int cipher)
        {
            string result = "";
            cipher %= 26;
            input.ToLower();
            foreach (var ch in input)
            {
                if ((ch>= 'a'&&ch<='m') || (ch>='A'&& ch<='M'))
                    result += Convert.ToChar(ch+cipher/2).ToString();
                else if ((ch >= 'n' && ch <= 'z') || (ch >= 'N' && ch <= 'Z'))
                    result += Convert.ToChar(ch-cipher/2).ToString();
                else result += ch;
            }
            return result;
        }
        public static string decryptString(string input, int cipher)
        {
            string result = "";
            cipher = (cipher % 26)*-1;
            foreach (var ch in input)
            {
                if ((ch >= 'a' && ch <= 'm') || (ch >= 'A' && ch <= 'M'))
                    result += Convert.ToChar(ch+cipher/2).ToString();
                else if ((ch >= 'n' && ch <= 'z') || (ch >= 'N' && ch <= 'Z'))
                    result += Convert.ToChar(ch-cipher/2).ToString();
                else result += ch;
            }
            return result;
        }
    }
}
