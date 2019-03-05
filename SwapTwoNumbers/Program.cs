using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumbers
{
    class Program
    {
        //The name of the game is swap two numbers with out using additional memory
        static void Main(string[] args)
        {

        }
        public static void swapIntNoExtraMemory(int one, int two)
        {
            one = one + two;
            two = one - two;
            two = one - two;
        }
    }
}
