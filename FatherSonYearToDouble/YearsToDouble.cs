using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatherSonYearToDouble
{
    public class YearsToDouble
    {

        //Goal:
        //We want to find when the father's age will be double the son's age
 
        //TODO: write unit test
        static void Main(string[] args)
        {
            Console.WriteLine("FatherSonYearToDouble.YearsToDouble");
            writeToConsole(yearsToDoubleAge(0, 2)); // 2 years from now
            writeToConsole(yearsToDoubleAge(8, 15));// 1 year ago
            writeToConsole(yearsToDoubleAge(2, 4));// This year
            Console.ReadLine();
            yearsToDoubleAge(4,2); // Exception Thrown
            Console.ReadLine();
        }

        public static int yearsToDoubleAge(int sonsAge, int fathersAge)
        {
            //A father cannot be younger than son
            if (sonsAge >= fathersAge) { throw new InvalidOperationException(); }

            //This difference will lead us to years to double
            int differenceInAge = fathersAge - sonsAge;

            //Could return negative or positive
            return differenceInAge-sonsAge;
        }

        //This is declared because we want to unit test our method above
        public static void writeToConsole(int number)
        {
            //Negative Case 
            if (number < 0)
            {
                //TODO: Write singular case
                Console.WriteLine($"The father's age was double {Math.Abs(number)} years ago.");
            }
            //Postive Case
            else if (number > 0)
            {
                //TODO: Write singular case
                Console.WriteLine($"The father's age will double in {number} years.");
            }
            //TODO: Write now case
            else if(number == 0)
            {
                Console.WriteLine($"The father's age is double now!");
            }
        }
    }
}
