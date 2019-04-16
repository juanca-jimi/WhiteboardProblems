using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadsAge2
{
    //Pass in Dad's age and son's age and find what year the dad's age will be twice the son's age
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int twiceSonsAge(int sonAge, int dadAge)
        {
            int son = 0;
            int DadsAge2 = 0;
            while (DadAge2 != sonAge*2)
            {
                DadsAge2++;
                son++;
            }

            return DadsAge2 - dadAge;
        }
    }
}
