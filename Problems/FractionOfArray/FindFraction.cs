using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionOfArray
{
    //Find the fraction of neg and pos numbers in your array
    class FindFraction
    {

        static void Main(string[] args)
        {
        }
        public static void yourFractions()
        {
            Console.WriteLine("Enter the amount of numbers you wish to enter!");
            int size = Convert.ToInt32(Console.ReadLine());
            double[] theArray = new double[size];
            int negNumbers = 0;
            int posNumbers = 0;
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.WriteLine($"Enter your {i+1} number");
                theArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < theArray.Length; i++)
            {
                if (theArray[i] > 0)
                {
                    posNumbers++;
                }
                else if (theArray[i] < 0)
                {
                    negNumbers++;
                }
            }
            Console.WriteLine($"Your positive numbers fraction is {posNumbers}/{size}");
            Console.WriteLine($"Your negative numbers fraction is {negNumbers}/{size}");

        }
    }
}
