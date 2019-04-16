using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    public class IsPrime
    {
        //TODO: implement exception handling
        static void Main(string[] args)
        {
            Console.WriteLine(isPrime(getNumber()));
        }
        public static int getNumber()
        {
            Console.WriteLine("Enter your number");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static bool isPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            if (num == 3) return true;
            for (int i = 2; i < num/2; i++)
            {
                if ((num%i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
