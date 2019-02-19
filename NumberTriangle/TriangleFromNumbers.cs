using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTriangle
{
    class TriangleFromNumbers
    {
        static void Main(string[] args)
        {
            createTriangle();
            Console.ReadLine();
        }
        public static void createTriangle()
        {
            Console.WriteLine("Input the number you wish to take your triangle up to");
            int howHigh = Convert.ToInt32(Console.ReadLine());
            for (int row = 1; row <= howHigh; row++)
            {
                for (int digit = 1; digit <= row; digit++)
                {
                    Console.Write(row);
                }
                Console.WriteLine();
            }
        }
    }
}
