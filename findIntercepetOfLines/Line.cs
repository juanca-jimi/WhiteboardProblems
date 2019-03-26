using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findIntercepetOfLines
{
    //TODO: write test cases in the main
    
    class Line
    {
        //The formula for the line is y=mx+b --- m = the slope and b = the y intercept
        //We need to find the x intercept of the line so we declare fields below

        public double yIntercept { get; set; }
        public double slope { get; set; }

        //When we instantiate the Line class we need to set those two fields 
        public Line(double yInterceptOfLine, double slopeOfLine)
        {
            yIntercept = yInterceptOfLine;
            slope = slopeOfLine;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Line line1 = new Line(3, 2);
            Line line2 = new Line(7, -.5);
            LineInterceptPoint(line1,line2);
        }

        //in our method we need to pass in two line types to find the Intercept of those two lines
        public static void LineInterceptPoint(Line line1, Line line2)
        {

            //Catches our parallel lines 
            if (line2.slope == line1.slope && line1.yIntercept != line2.yIntercept)
            {
                Console.WriteLine("Your lines are parrallel. /nThey never intercept!");
                //Don't continue in the method
                return;
            }

            //Catches our same lines
            if (line2.slope == line1.slope && line1.yIntercept == line2.yIntercept)
            {
                Console.WriteLine("Your lines are the same! /nThey always intercept.");
                //Don't continue in the method
                return;
            }

            //Will not throw a DivideByZero Exception because that would be parallel lines and we already caught that
            double XInterceptOfTwoLines = (line1.yIntercept - line2.yIntercept) / (line1.slope - line2.slope);

            Console.WriteLine($"({XInterceptOfTwoLines}) is your point where your lines intercept on the x Axis");
        }
    }
    
}
