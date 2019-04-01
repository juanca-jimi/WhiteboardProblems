using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorIntDigits

{
    class FlipInt
    {
        //TODO: Write unit test
        static void Main(string[] args)
        {
            Console.WriteLine(flipDigits(12345));
        }
        public static int flipDigits(int input)
        {
            int reversedInt = 0;
            while (input > 0)
            {
                reversedInt *= 10;
                reversedInt += input % 10;
                input /= 10;
            }
            return reversedInt;
        }
    }
}
