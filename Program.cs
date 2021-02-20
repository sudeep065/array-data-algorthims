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
            //int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int result = simpleArraySum(ar);

            //int[] arr = { 203, 204 ,205 ,206 ,207 ,208 ,203 ,204 ,205 ,206 };
            //int[] brr = { 203, 204 ,204 ,205 ,206 ,207 ,205 ,208 ,203 ,206 ,205 ,206 ,204 };
            //int[] result = missingArrayFromInput(arr, brr);
            //foreach (int a in result)
            //    Console.WriteLine("/n {0}", a);
            //int[] ar = { 1, -2, 3, 4, 5, -6, -7, 8, 0, 0 };
            //plusMinus(ar);
            
            Console.ReadLine();            
        }


        # region -- Simple Array
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
        #endregion

        # region -- Sum Of Diagonals
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
        #endregion

        # region -- MinMaxSum
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
        #endregion

        # region -- Tallest Duplicates
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
        #endregion

        #region -- Plus Minus
        // Plus Minus- Zero count and divide by the array.length.
        static void plusMinus(int[] arr)
        {
            int positive = 0, negative = 0, zero = 0;
            if (arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 0)
                    {
                        zero++;
                    }
                    else if (arr[i] < 0)
                    {
                        negative++;
                    }
                    else
                    {
                        positive++;
                    }
                }
                Console.WriteLine("{0}\n {1}\n {2}\n", (float)positive / arr.Length, (float)negative / arr.Length, (float)zero / arr.Length);
            }
        }
        #endregion

        public static int[] missingArrayFromInput(int[] arr, int[] brr)
        {
            // int[] c = arr.Concat(brr).Distinct().ToArray();
            //int[] same = arr.Intersect(brr).ToArray(); ;
            //int[] diff = arr.Union(brr).Except(same).ToArray();
            //int[] c = new int[] { diff[0], same[0], same[1], diff[1] };
            Array.Sort(arr);
            Array.Sort(brr);
            List<int> index = new List<int>();
                        
            for (int i = 0, j = 0; i < brr.Length; i++, j++)
            {
                int checkNo = 0;
                if (j == arr.Length)
                {
                    j--;
                    checkNo = brr[i];
                }
                else if (arr[j] != brr[i])
                {
                    checkNo = brr[i];
                }
                bool isDuplicate = index.Exists(x => x == checkNo);
                if (!isDuplicate)
                    if(checkNo != 0)
                        index.Add(checkNo);
            }
            return null;
        }

        #region - Staircase --upward --downward --triangle
        // Complete the staircase function below.
        static void staircase(int n)
        {
            //Staircase --upward
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                    Console.WriteLine(new String('#', i).PadLeft(n, ' '));
            }
            //Staircase --downward
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                    Console.WriteLine(new String('#', i).PadRight(n, ' '));
            }

            #region -- another way of making triangle.
            int height = 6;
            int count = height;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < count; column++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                count--;
            }
            #endregion
        }
        #endregion
    }
}
