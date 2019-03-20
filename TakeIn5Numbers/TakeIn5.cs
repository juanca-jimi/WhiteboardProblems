using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeIn5Numbers
{
    //Get the maximum sum and the minimum sum of 4 integers after recieving 5 from the user

    //TODO: implement unit test

    //Additional solution could be adding up all digits and 
    //subtracting min int to find top 5 and max int to find bottom 5

    //TODO: implement exception handling

    //Got scope creep

    class TakeIn5
    {
        static void Main(string[] args)
        {
            Console.WriteLine(maxSumOf4Numbers(sortInput(getNumberArray(prompt()))));
            Console.WriteLine(minSumOf4Numbers(sortInput(getNumberArray(prompt()))));
        }
        public static int prompt()
        {
            Console.WriteLine("Enter how many numbers you wish to get the sum of top 4 numbers and bottom 4 numbers");
            Console.WriteLine("Minimum of four");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int[] getNumberArray(int amountOfNumbers)
        {
            int[] numberArray = new int[amountOfNumbers];
            for (int i = 0; i < amountOfNumbers; i++)
            {
                Console.WriteLine($"Enter your {i+1} number");
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numberArray;
        }
        public static int[] sortInput(int[] yourOriginalNumbers)
        {
            Array.Sort(yourOriginalNumbers);
            return yourOriginalNumbers;
        }
        public static int maxSumOf4Numbers(int[] sortedNumbers)
        {
            int max = 0;
            for (int i = sortedNumbers.Length-1; i > sortedNumbers.Length-5; i--)
            {
                 max += sortedNumbers[i];
            }
            return max;
        }
        public static int minSumOf4Numbers(int[] sortedNumbers)
        {
            int min = 0;
            for (int i = 0; i < 4; i++)
            {
                min += sortedNumbers[i];
            }
            return min;
        }
    }
}
