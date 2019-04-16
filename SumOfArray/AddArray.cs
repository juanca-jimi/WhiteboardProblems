using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArray
{
    //GOAL:
    //Declaring an array with the user ... ooooohhhhh
    //And adding all the integers in the array
    public class AddArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SumOfArray.AddArray");
            yourSum();
        }
        public static void yourSum()
        {
            //This is to declare the size of the array
            Console.WriteLine("Enter how many numbers you wish to enter!");

            // saving the integer of the size of the array
            int size = Convert.ToInt32(Console.ReadLine());

            //Instantiating and declaring the size of the with our int variable
            int[] theArray = new int[size];

            //our "Return" integer
            //Not really returning but writing to the console
            int sum = 0;

            //This is input our numbers into each index of the array
            for (int i = 0; i < theArray.Length; i++)
            {
                
                Console.WriteLine($"Enter your {i+1} number");

                //TODO: Implement exception handling if you cannot convert this to an integer
                theArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Simply adds each index to our "Return" int
            foreach (int i in theArray)
            {
                sum += i;
            }

            Console.WriteLine($"The sum of your numbers is {sum}!");

            Console.ReadKey();
        }
    }
}
