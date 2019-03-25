using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarquiLetterCount
{
    class Marquis
    {
        static void Main(string[] args)
        {
        }
        public static void letterCounts(string movieTitle)
        {
            movieTitle = movieTitle.ToUpper();
            for (char c = 'A'; c < 'Z'; c++)
            {
                int count = 0;
                if (movieTitle.Contains(c.ToString()))
                {
                    foreach (var ch in movieTitle)
                    {
                        if (ch==c)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{c} - {count}");
                }
            }
        }
    }
}
