using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPrimes
{
    public class AddPrimes
    {
        //TODO: write unit test
        static void Main(string[] args)
        {
            //Set this as your startup project if not listed
            Console.WriteLine("This is your AddPrimes proj");
            Console.WriteLine(SumOfPrimes(200));
        }
        public static int SumOfPrimes(int input)
        {
            //Our return integer that will get incremented
            int output = 0;

            //our input is greater than 1 we'll hop int this loop that will add our primes
            if (input > 1)
            {

                for (int i = 2; i <= input ; i++)
                {
                    if (IsPrime(i))
                    {
                        //add it to our return integer
                        output += i;
                    }
                    
                    //This is not as efficient as new solution
                    //Because we're not constantly added... just adding if it's prime
                    //output += (IsPrime(i)) ? i : 0;
                }

            }

            return output;
        }

        //Our boolean that checks whether your input is prime
        public static bool IsPrime(int input)
        {
            //1, 0 & Negative numbers are not Prime
            if (input  <= 1 ) return false;

            //Hard coded case to catch our 2 and return true
            else if (input == 2) return true;

            //If its greater than 2 we'll jump into this loop
            else if (input > 2)
            {
                for (
                    //Begin dividing by 2 and if divisible by this integer then it's not prime
                    int i = 2; 

                    //To save runtime were going to stop at half because we don't need to check further
                    i < input/2

                    //Increment by 1
                    ; i++)
                {
                    //If the remainder of our integer is perfectly divisible by an integer then it is not a prime
                    //We'll return false in this case
                    if (input % i == 0)
                    {
                        return false;
                    }
                }
            }

            //If none of your cases are false then we'll return tre
            return true;
        }
    }
}
