using System;
using System.Collections.Generic;
using System.Text;

namespace Batchen
{
    public class ArrRec
    {
        public static int T14(int[] arr, int i)
        {
            if (i == 0)
            {
                return arr[0];
            }
            return arr[i] + T14(arr, i - 1);
        }

        public static int T15(int[] arr, int i)
        {
            if (i == 0)
            {
                if (arr[0] > 0) return 1;
                else return 0;
            }
            if (arr[i] > 0)
            {
                return 1 + T15(arr, i - 1);
            }
            else return T15(arr, i - 1);
        }

        public static int T16(int[] arr, int num, int i = 0)
        {
            if (i >= arr.Length)
            {
                return -1;
            }
            else if (num == arr[i])
            {
                return i;
            }
            else
            {
                return T16(arr, num, i + 1);
            }
        }

        public static bool T17(int[] arr)
        {
            return T17(arr, arr.Length - 1);
        }
        public static bool T17(int[] arr, int i)
        {
            if (i == 0) return true;

            if (arr[i] > arr[i - 1])
            {
                return T17(arr, i - 1);
            }
            else return false;
        }

        public static bool T18(int[] arr)
        {
            return T18(arr, arr.Length - 1);
        }

        public static bool T18(int[] arr, int i)
        {
            if (i >= 0)
            {
                if (Recursion.T8(arr[i], 2))
                {
                    return false;
                }
                else
                {
                    return T18(arr, i - 1);
                }
            }
            return true;
        }

        public static bool T19Ezer(int[,] arr, int row, int col, int num)
        {
            if (col < 0)
            {
                return false;
            }

            if (arr[row, col] == num) return true;

            return T19Ezer(arr, row, col - 1, num);

        }

        public static int T19(int[,] arr, int i, int num)
        {
            if (i < 0)
            {
                return 0;
            }

            if (T19Ezer(arr, i, arr.GetLength(1), num)) return 1 + T19(arr, i - 1, num);

            return T19(arr, i - 1, num);
        }

        public static bool T20(int[] arr)
        {
            Random rnd = new Random();
            int r1 = rnd.Next(0, arr.Length);
            int r2 = rnd.Next(0, arr.Length);

            Console.WriteLine($"r1 = {r1}, r2 = {r2}");

            return T20(arr, Math.Min(r1, r2), Math.Max(r1, r2));
        }

        public static bool T20(int[] arr, int iLeft, int iRight)
        {
            if (iLeft >= iRight) return true;

            if (arr[iLeft] != arr[iRight]) return false;

            return T20(arr, iLeft + 1, iRight - 1);
        }

        public static void UnitTest()
        {
            //Console.WriteLine(T14(new int[] { 1, 2, 3, 4, 5 }, 3));

            //Console.WriteLine(T15(new int[] { -1, 2, 3, -4, 5, -17, 18 }, 5));

            //Console.WriteLine(T16(new int[] {1, 2, 3, 4, 5}, 16));
            //Console.WriteLine(T16(new int[] { 1, 2, 3, 4, 5 }, 4));

            //Console.WriteLine(T17(new int[] {1, 2, 3, 32, 54}));
            //Console.WriteLine(T17(new int[] { 5, 2, 3, 32, 54 }));

            //Console.WriteLine(T18(new int[] { 1, 2, 4, 6, 8, 10 }));
            //Console.WriteLine(T18(new int[] { 16, 18, 4, 6, 8, 10 }));

            /*
             * wrong!!!! I need to change it.
            Console.WriteLine(T19(new int[,] { { 3, 4, 5},
                                               {4, 5, 7 },
                                               {5, 7, 4 } }, 2, 4));
            */

            //Console.WriteLine(T20(new int[] {1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10}));
            //Console.WriteLine(T20(new int[] { 1, 1, 1, 1, 1, 1, 10 }));


            //Exercises 19(redo), 21, 22, and 23 are missing.
        }
    }
}
