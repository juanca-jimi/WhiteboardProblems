using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPrimes
{
    public class AddPrimes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is your AddPrimes proj");
            Console.WriteLine(SumOfPrimes(200));
        }
        public static int SumOfPrimes(int input)
        {
            int output = 0;
            if (input > 1)
            {
                for (int i = 2; i <= input ; i++)
                {
                    output += (IsPrime(i)) ? i : 0;
                }
            }
            return output;
        }

        public static bool IsPrime(int input)
        {
            if (input == 1 || input == 0) return false;
            if (input == 2) return true;
            if (input > 1)
            {
                for (int i = 2; i < input; i++)
                {
                    if (input % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
