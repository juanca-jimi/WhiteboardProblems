using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    public class IsPrime
    {
        //TODO: Write Unit Test
        static void Main(string[] args)
        {
            Console.WriteLine(isPrime(getNumber()));
            Console.ReadLine();
        }

        //This method retrieves an Integer from the user
        public static int getNumber()
        {
            Console.WriteLine("Enter your number");

            //TODO: Handle exceptions from retrieving something that can't be converted to an integer
            return Convert.ToInt32(Console.ReadLine());
        }

        //After retrieving our number we're checking if it's prime
        //Return true or false
        public static bool isPrime(int num)
        {
            //if number is less than 2 it's automatically false
            if (num < 2) return false;

            //We'll only check up to half of the input number because to improve runtime

            //Checking only half will be sufficient because if a number is prime for the first half.. 
            //it will always be prime for the second half

            for (int i = 2; i < num/2; i++)
            {

                //Dividing our input by an incrementer "i" UP TO (input/2)
                //If the number divided by our I contains a remainder then it's prime
                //If it does not contain a remainder then it is perfectly divisible and NOT a prime
                if ((num%i) == 0)
                {
                    return false;
                }

            }

            //If it doesn't meet conditions to return false in for loop 
            //we'll return true 
            return true;
        }
    }
}
