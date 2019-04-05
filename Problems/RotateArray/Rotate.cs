using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Rotate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t RotatingArray.Rotate");
            answer();
        }
        private static void prompt(int[] A, int[] B, int[] C)
        {
            Console.WriteLine("The values in Array A are");
            displayArrValues(A);
            Console.WriteLine("\nThe values in Array B are");
            displayArrValues(B);
            Console.WriteLine("\nThe values in Array C are");
            displayArrValues(C);
        }
        private static void answer()
        {
            int[] A = { 0, 2, 4, 6, 8, 10 };
            int[] B = { 1, 3, 5, 7, 9 };
            int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            prompt(A, B, C);
            Console.WriteLine("\nplease select array to rotate!");
            string Answer = Console.ReadLine().ToLower();
            if (Answer == "a") RotArr(A);
            else if (Answer == "b") RotArr(B);
            else if (Answer == "c") RotArr(C);
            else
            {
                Console.Clear();
                Console.WriteLine("Please Try Again \n");
                prompt(A, B, C);
            }
        }

        private static void RotArr(int[] input)
        {
            Console.WriteLine("The values in your array are");
            displayArrValues(input);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Would you like to rotate your array left or right? \nIf you wish to end enter: \"end\".");
            string Direction = Console.ReadLine().ToLower();
            if (Direction == "left")
            {
                int temporaryValue = input[0];
                for (int i = 0; i < input.Length - 1; i++)
                {
                    input[i] = input[i + 1];
                }
                input[input.Length - 1] = temporaryValue;
                Console.Clear();
                RotArr(input);
            }
            else if (Direction == "right")
            {
                int temporaryValue = input[input.Length - 1];
                for (int i = input.Length - 1; i >= 1; i--)
                {
                    input[i] = input[i - 1];
                }
                input[0] = temporaryValue;
                Console.Clear();
                RotArr(input);
            }
            else if (Direction == "end")
            {
                Console.Clear();
                Console.WriteLine("Thank you for your time.");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\tYou have entered the wrong input. \n\tPlease try again.\n");
                RotArr(input);
            }
        }
        private static void displayArrValues(int[] input)
        {
            foreach (int i in input) Console.Write(i + " ");
        }

    }
}
