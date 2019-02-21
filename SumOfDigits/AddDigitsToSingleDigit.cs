using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    public class AddDigitsToSingleDigit
    {
        public static int sum = 0;
        public static int SumOfDigits(int Number)
        {
            if (Number > 10)
            {
                for (int i = 0; i < ; i++)
                {
                    
                }
            }
            return (sum > 9 ? SumOfDigits(sum) : sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t SumOfDigits.AddDigitsToSingleDigit");
            Console.WriteLine(SumOfDigits(12345));
            Console.ReadLine();
        }
    }
}
