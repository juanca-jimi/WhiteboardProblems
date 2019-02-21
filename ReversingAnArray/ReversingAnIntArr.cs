using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingArrays
{
    public class ReversingAnIntArr
    {
        static void Main(string[] args)
        {

        }
        public static int[] rev(int[] input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                int tempValue = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = tempValue;
            }
            return input;
        }
    }
}
