using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimumIntInArray
{
    public class MinInt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t This is minimumIntInArray.MinInt");
            int[] input = { 10, 25, 3, 2100, 11023 };
            Console.WriteLine(getMininumInt(input));
            Console.ReadLine();
        }
        public static int getMininumInt(int[] input)
        {
            int output = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] < output)
                {
                    output = input[i];
                }
            }
            return output;
        }
    }
}
