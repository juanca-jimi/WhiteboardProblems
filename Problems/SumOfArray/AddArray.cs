using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArray
{
    public class AddArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" SumOfArray.AddArray");
            yourSum();
        }
        public static void yourSum()
        {
            Console.WriteLine("Enter how many numbers you wish to enter!");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] theArray = new int[size];
            int sum = 0;
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.WriteLine($"Enter your {i+1} number");
                theArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in theArray)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of your numbers is {sum}!");
            Console.ReadKey();
        }
    }
}
