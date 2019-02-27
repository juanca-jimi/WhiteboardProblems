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
            for (int rowNumber = 1; rowNumber <= howHigh; rowNumber++)
            {
                for (int digits = 1; digits <= rowNumber; digits++)
                {
                    Console.Write(rowNumber);
                }
                Console.WriteLine();
            }
        }
    }
}
