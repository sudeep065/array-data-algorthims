using System;
using System.Collections.Generic;
using System.IO;

namespace array_data_algorthims
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = simpleArraySum(ar);

            Console.WriteLine("Sum of array = {0}", result);
            Console.ReadLine();            
        }

        // Simple array Sum Function goes here.
        public static int simpleArraySum(int[] ar)
        {
            /* SimpleArraySum function below.. */
            int result = 0;
            if (ar.Length > 0)
            {
                foreach (int eachElement in ar)
                {
                    result += eachElement;
                }
            }
            return result;
        }
    }
}
