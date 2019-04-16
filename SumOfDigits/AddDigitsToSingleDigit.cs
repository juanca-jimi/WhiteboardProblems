using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    //Here we're trying to get the sum of the digits in the int until it adds to a single digit
    //EX: 123 = 6... 546 = 15 = 6.... 7463 = 20 = 2
    public class AddDigitsToSingleDigit
    {
        public static int SumOfDigits(int Number)
        {
            //Declaring our return integer
            int sum = 0;

            //Handles our exceptional case of negative numbers Math.Abs(Number)
            while (Math.Abs(Number) > 0)
            {
                // Modulus ten returns our first digit 
                //123 % 10 will return ...3
                //Then we'll add it to our return integer
                sum += Number % 10;
                
                //We'll divide out Input Number by ten and since
                //Number is an integer we'll return just the following digits
                //123 / 10 = 12
                //12 / 10 = 1
                //1 / 10 = 0
                //until we reach 0 and hop out of the loop
                Number /= 10;

            }

            //If our return integer is greater than 9 (Which would be double digits)
            //Call this method (Recursively)
            //Else the sum is sufficiently ... 1 digit

            return sum > 9 ? SumOfDigits(sum): sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t SumOfDigits.AddDigitsToSingleDigit");

            //Test case should return 12345 = 15 = ...6

            Console.WriteLine(SumOfDigits(12345));//6

            Console.ReadLine();
        }
    }
}
