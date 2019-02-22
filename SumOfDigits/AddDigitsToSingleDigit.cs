using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    public class AddDigitsToSingleDigit
    {
        public static int SumOfDigits(int Number)
        {
            int sum = 0;
            while (Number > 0)
            {
                sum += Number % 10;
                Number /= 10;
            }
            sum = (sum > 9) ? SumOfDigits(sum): sum;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t SumOfDigits.AddDigitsToSingleDigit");
            Console.WriteLine(SumOfDigits(12345));
            Console.ReadLine();
        }
    }
}
