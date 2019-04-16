using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfLeapYear
{
    public class IsLeapYear
    {
        static void Main(string[] args)
        {
            
        }
        public static int enterYear()
        {
            int year = 0;
            Console.WriteLine("Enter year that you want to check");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Try Again");
                enterYear();
            }
            return year;
        }
        public static bool isLeapYear(int year)
        {
            bool isLeapYear = false;
            if (year%4==0)
            {
                isLeapYear = true;
            }
            return isLeapYear;
        }
    }
}
