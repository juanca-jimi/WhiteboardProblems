using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderName
{
    public class OrderInputString
    {
        static void Main(string[] args)
        {
            Console.WriteLine(orderName("Garrett"));
        }
        public static string orderName(string input)
        {
            input = input.ToLower();
            char[] orderArray = input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (orderArray[j] > orderArray[j+1])
                    {
                        char tempVal = orderArray[j+1];
                        orderArray[j+1] = orderArray[j];
                        orderArray[j] = tempVal;
                    }
                }
            }
            string orderedName = "";
            for(int i = 0; i< input.Length;i++ )
            { 
                orderedName += orderArray[i];
            }
            return orderedName;
        }
    }
}
