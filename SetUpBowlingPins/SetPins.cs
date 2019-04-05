using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetUpBowlingPins
{
    class SetPins
    {
        //todo:Write unit test
        static void Main(string[] args)
        {
            SetUpPins();
            Console.ReadLine();
        }
        public static void SetUpPins()
        {
            Console.WriteLine("How Many pins do you want to set up?");
            int pins = Convert.ToInt32(Console.ReadLine());
            int pinsLeft = pins;
            int declaredRows = findRowNumbers(pins);
            for (int Row = declaredRows; Row > 0; Row--)
            {
                for (int j = pinsLeft - Row +1 ; j <= pinsLeft; j++)
                {
                    Console.Write(j + " ");
                }
                pinsLeft -= Row;
                Console.WriteLine();
            }
        }
        public static int findRowNumbers(int n)
        {
            int j = 0;
            if (isPinnable(n))
            {
                int count = 0;
                for (int i = 1; i <= n; i++)
                {
                    count += i;
                    if (count == n)
                    {
                        return i;
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please Try Again\n");

                SetUpPins();
            }
            return j;
        }

        public static bool isPinnable(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                count += i;
                if (count == n)
                {
                    return true;
                }
                if (count > n) break;
            }
            return false;
        }
    }
}
