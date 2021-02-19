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

        // Given a square matrix, calculate the absolute difference between the sums of its diagonals.
        public static int diagonalDifference(List<List<int>> arr)
        {
            int diag1Sum = 0; //TL > BR
            int diag2Sum = 0; //TR > BL
            int col = 0;
            for (int row = 0; row < arr.Count; row++)
            {
                diag1Sum += arr[row][col]; //[2][2] = -12
                diag2Sum += arr[row][arr[row].Count - 1 - col]; //[2][3 - 1 - 2]= [0] == 10
                col++;
            }
            return Math.Abs(diag1Sum - diag2Sum);
        }
    }
}
