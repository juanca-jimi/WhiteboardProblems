using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFibonacciDigits
{
    class PrintFib
    {
        static void Main(string[] args)
        {
        }
        public static void printFib()
        {
            Console.WriteLine("Enter number of digits you wish to show in the fibonacci series");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input>2)
            {
                int first = 0;
                int second = 1;
                if (input == 1) { Console.WriteLine(first); return; }
                if (input == 2) { Console.WriteLine(second); return; }
                Console.WriteLine(first);
                Console.WriteLine(second);
                for (int i = 2; i < input; i++)
                {
                    int newNumber = first + second;
                    Console.WriteLine(newNumber);
                    first = second;
                    second = newNumber;
                }

            }
        }
    }
}
