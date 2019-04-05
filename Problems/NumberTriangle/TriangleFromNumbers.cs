using System;

namespace NumberTriangle
{
    class TriangleFromNumbers
    {
        static void Main(string[] args)
        {
            //Set as start up project
            Console.WriteLine("This is your Number Triangle");

            createTriangle();
        }
        public static void createTriangle()
        {
            //Keeps this in scope throughout the whole method
            int triangleHeight = 0;

            Console.WriteLine("Input the number you wish to take your triangle up to");

            try
            {
                //Get triangle height from the user
                triangleHeight = Convert.ToInt32(Console.ReadLine());
            }

            //If we cannot convert to an integer
            //Catch our exception and call the method recursively with the console cleared
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please Try Again\n");
                createTriangle();
            }

            
            for (
                //This is the number we're printing in every row
                int rowNumberNumber = 1; 
                //Don't stop til we reach the height of the triangle which is the number input by the user
                rowNumberNumber <= triangleHeight; 
                //increment by one
                rowNumberNumber++)
            {
                //Nested loop
                for (
                    //This is the amount of digits we'll print out
                    int digits = 1;
                    
                    //If we're at rowNumberNumber = 2 
                    //print two digits of the rowNumberNumber
                    digits <= rowNumberNumber;
                    
                    //increment by one
                    digits++)
                {
                    //Don't start a new line and print the digit
                    Console.Write(rowNumberNumber);
                }

                //Start a new line for a row number
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
