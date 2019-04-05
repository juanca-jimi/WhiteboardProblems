using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabblePoints
{
    class PointsFromDictionary
    {
        //TODO: Write unit test
        static void Main(string[] args)
        {
            //j=8 i=1 m=3 i=1
            Console.WriteLine(PointTest("jimi")); //13
        }
        //Declare new dictionary for points
        static readonly Dictionary<char, int> Scrabble = new Dictionary<char, int>
        // fill the point system
        {
            { 'a', 1 },{'b', 3 },{'c', 3 },{'d', 2 },{'e', 1 },{'f', 4 },
            { 'g', 2 },{'h', 4 },{'i', 1 },{'j', 8 },{'k', 5 },{'l', 1 },
            { 'm', 3 },{'n', 1 },{'o', 1 },{'p', 3 },{'q', 10 },{'r', 1 },
            { 's', 1 },{'t', 1 },{'u', 1 },{'v', 4 },{'w', 4 },{'x', 8 },
            { 'y', 4 },{'z', 10 },
        };
        
        public static int PointTest(string input)
        {
            int nPoints = 0;
            //our dictionary collection is in lower case
            input = input.ToLower();
            foreach (char ch in input)
            {
                nPoints += Scrabble[ch];
            }
            return nPoints;
        }
    }
}
