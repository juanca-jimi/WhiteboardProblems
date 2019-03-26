using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatherSonYearToDouble
{
    public class YearsToDouble
    {
        //We want to return how many years ago or from now the sons and fathers age will double
        //TODO: write unit test
        static void Main(string[] args)
        {
            //TODO: write test cases in main
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
    }
}
