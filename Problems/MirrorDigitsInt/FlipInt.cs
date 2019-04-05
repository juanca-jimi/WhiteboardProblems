using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorIntDigits
//The Aim of this problem is to return an integer in the reverse order
//In other words if we pass in 765 we should return 567
{
    class FlipInt
    {
        //TODO: Write unit test
        static void Main(string[] args)
        {
            //Writes 321
            Console.WriteLine(flipDigits(123));
            Console.ReadLine();
        }
        public static int flipDigits(int input)
        {
            //Test input = 123
            //Our return int
            int reversedInt = 0;

            //We want our input to be modulused(to retrieve digit value) 
            //then divided til it reaches 0(our boolean)
            while (input > 0)
            {
                //first iteration 0*10=0...
                //Second iteration 3*10=30
                //Third iteration 32*10=320
                reversedInt *= 10;

                //first iteration 123%10=3
                //Second iteration 12%10=2
                //Third iteration 1%10=1
                reversedInt += input % 10;

                //first iteration 123/10=12...(integer math)
                //Second iteration 12/10=1
                //Third iteration 1/10=0 Our break boolean
                input /= 10;
            }

            return reversedInt;//321
        }
    }
}
