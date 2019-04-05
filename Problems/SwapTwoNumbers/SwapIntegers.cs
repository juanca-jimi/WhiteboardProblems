using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumbers
{
    class SwapIntegers
    {
        //The name of the game is swap two numbers with out using additional variables
        static void Main(string[] args)
        {
            swapIntsNoExtraMemory(firstInteger: 5, secondInteger: 7);
            Console.ReadLine();
        }
        public static void swapIntsNoExtraMemory(int firstInteger, int secondInteger)
        {
            //Display orignal values
            Console.WriteLine($"Your first value is {firstInteger}" +
                $" and your second value is {secondInteger}");

            //Changing the firstInterger
            //12          = 5            + 7
            firstInteger  = firstInteger + secondInteger;

            //Making the second int the first int
            //5            = 12           - 7
            secondInteger = firstInteger - secondInteger;

            //Getting the first interger back
            //7          =  12          - 5            
            firstInteger = firstInteger - secondInteger;

            //Display new values
            Console.WriteLine($"Now your first value is {firstInteger}" +
                $" and your second value is {secondInteger} ;)");
        }
    }
}
