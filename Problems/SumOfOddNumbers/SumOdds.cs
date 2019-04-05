using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    // Adding the sum of the odd numbers up to any number passed in
    // I would check this whole project if it overflows
    // proj -> Properties -> build -> advanced -> "check int over/under"
    public class SumOdds
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t This is your SumOfOddNumbers project");
            Console.WriteLine(sumOfOdds(5));
        }
        public static int sumOfOdds(int input)
        {
            int output = 0;
            for (int i = 0; i <= input; i++)
            {
                if (i%2 == 1) //odd 
                {
                    output += i;
                }
            }
            return output;
        }
    }
}
