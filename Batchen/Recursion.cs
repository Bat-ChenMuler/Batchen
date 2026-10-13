using System;
using System.Collections.Generic;
using System.Text;

namespace Batchen
{
    public class Recursion
    {

        public static int T1(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n + T1(n - 1);
        }

        public static int T2(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * T2(n - 1);
        }

        public static int T3(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            if (n % 2 == 0)
            {
                return n * T3(n - 1);
            }

            return n * T3(n - 2);
        }

        public static int T4(int n)
        {
            if (n < 10)
            {
                return 1;
            }

            return 1 + T4(n / 10);
        }

        public static int T5(int a, int b)
        {
            if (a < b)
            {
                return 0;
            }
            int count = 1;

            return count + T5(a - b, b);
        }

        public static int T6(int a, int b)
        {
            if (a < b)
            {
                return a;
            }

            return T6(a - b, b);
        }

        public static bool T7(int x, int y)
        {
            if (x == y)
            {
                return true;
            }
            if (x < 0)
            {
                return false;
            }

            return T7(x - y, y);
        }

        public static bool T8(int num, int divider)
        {
            if (divider > 10 || num == divider)
            {
                return true;
            }
            if (num % 2 == 0)
            {
                return false;
            }
            if (num % divider == 0)
            {
                return false;
            }

            return T8(num, divider += 1);
        }

        public static bool T9(int num)
        {
            if (num < 10)
            {
                return true;
            }

            if ((num % 10) % 2 != ((num / 10) % 10) % 2)
            {
                return false;
            }

            return T9(num / 10);
        }

        public static int T10(int n)
        {
            if (n < 1)
            {
                return n;
            }

            if (n % 2 == 1)
            {
                return n * 2 + T10(n - 1);
            }
            else
            {
                return n * n + T10(n - 1);
            }
        }

        public static double T11(int n)
        {
            if (n == 0)
            {
                return n;
            }

            if (n % 2 == 0)
            {
                return -Math.Sqrt(n * 2 - 1) + T11(n - 1);
            }
            else
            {
                return (n * 2 - 1) + T11(n - 1);
            }
        }

        public static int T12(int n1, int n2)
        {
            if (n2 < n1)
            {
                return 0;
            }

            return n1 + T12(n1, n2 - n1);
        }

        public static int T13a(int i, int a, int b)
        {
            int c = a * a + b * b;
            if (i == 3)
            {
                return c;
            }
            return T13a(i - 1, b, c);
        }

        public static int T13b(int i)
        {
            return 1 + T13b(i, 0, 1);
        }
        private static int T13b(int i, int a, int b)
        {
            int c = a * a + b * b;
            if (i == 3)
            {
                return c;
            }
            return c + T13b(i - 1, b, c);
        }

        public static void UnitTest()
        {
            //Console.WriteLine(T1(3));
            //Console.WriteLine(T13b(6));
        }
    }
}
