using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

        // Min Max Sum Given Array
        public static void minMaxSumGivenArray(int[] arr)
        {
            #region
            // input = {1, 2, 3, 4, 5} - Calculate the sum of integers, display Min and Max of sum.
            // int[] arr = { 1, 2, 3, 4, 5 }; // {7, 69, 2, 221, 7864}
            List<long> result = new List<long>();
            for (int i = 0; i < arr.Length; i++)
            {
                long sum = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        sum += arr[j];
                    }
                }
                result.Add(sum);
            }
            Console.WriteLine("{0} {1}", result.Min(), result.Max());
            #endregion

            #region
            // short and best answer for getting min and max sum.
            Array.Sort(arr);
            long min = 0, max = 0;
            for (int i = 0, j = arr.Length - 1; i < arr.Length - 1; i++, j--)
            {
                max = max + arr[j];
                min = min + arr[i];
            }
            Console.WriteLine("{0} {1}", min, max);
            Console.ReadLine();
            #endregion
        }

        // Count how many candles are tallest in a given array.
        public static int birthdayCakeCandles(List<int> candles)
        {
            int noOfCandles = 0, max = 0;
            if (candles.Count > 0)
            {
                max = candles.Max();
                for (int i = 0; i < candles.Count; i++)
                {
                    if (max == candles[i])
                        noOfCandles++;
                }

            }
            return noOfCandles;
        }

    }
}
