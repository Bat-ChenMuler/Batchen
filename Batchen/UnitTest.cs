using System;
using System.Collections.Generic;
using System.Text;

namespace Batchen
{
    public class UnitTest
    {
        public static void Run()
        {
            //Test1();

            //Print Test:
            //IntNode n2 = new IntNode(51);
            //IntNode n1 = new IntNode(3, n2);
            //IntNode n = new IntNode(42, n1);
            //n2 = null;
            //n1 = null;
            //Console.WriteLine(Print(n));
            //Console.WriteLine("\n" + n);

            IntNode n3 = new IntNode(2);
            IntNode n2 = new IntNode(9, n3);
            IntNode n1 = new IntNode(88, n2);
            IntNode n = new IntNode(17, n1);
            Console.WriteLine(Print(n));
            Console.WriteLine("-------------------------------------------------------------------");

            // T1 Test:
            //Console.WriteLine(T1(n));

            //T2 Test:
            //Console.WriteLine(T2(n));

            //T3 Test:
            //Console.WriteLine(T3(n));

            //T4 Test:
            //Console.WriteLine(T4(n));

            //T5 Test:
            //Console.WriteLine(T5(n,91));
            //Console.WriteLine(T5(n, 2));

            //T6 Test:
            //Console.WriteLine(T6(n));

            //Page 76 T2 Test:
        }
        public static void Test1()
        {
            IntNode n2 = new IntNode(51);
            IntNode n1 = new IntNode(3, n2);
            IntNode n = new IntNode(42, n1);
            n2 = null;
            n1 = null;

            //Console.WriteLine(n1);
            //Console.WriteLine(n);
            //Console.WriteLine(n.GetNext());

            n.GetNext().GetNext().SetNext(new IntNode(99));
            n.GetNext().GetNext().SetNext(null);

            bool b = true;
            IntNode temp = n;
            while (b)
            {
                Console.WriteLine(temp);
                temp = temp.GetNext();
                if (temp == null)
                    b = false;
            }
        }

        public static string Print(IntNode temp)
        {
            string s = "-->";
            while (temp != null)
            {
                s += temp.ToString() + "-->";
                temp = temp.GetNext();
            }
            s += "null";
            return s;
        }

        public static int T1(IntNode lst)
        {
            int sum = 0;
            while (lst != null)
            {
                sum += lst.GetValue();
                lst = lst.GetNext();
            }
            return sum;
        }

        public static int T2(IntNode lst)
        {
            int count = 0;
            while (lst != null)
            {
                if (lst.GetValue() % 2 == 1)
                {
                    count++;
                }
                lst = lst.GetNext();
            }
            return count;
        }

        public static int T3(IntNode lst)
        {
            int sumEven = 0, sumOdd = 0;
            while (lst != null)
            {
                if (lst.GetValue() % 2 == 0)
                {
                    sumEven += lst.GetValue();
                }
                else
                {
                    sumOdd += lst.GetValue();
                }
                lst = lst.GetNext();
            }
            return Math.Abs(sumOdd - sumEven);
        }

        public static bool T4(IntNode lst)
        {
            int countP = 0, countN = 0;
            while (lst != null)
            {
                if (lst.GetValue() >= 0)
                {
                    countP++;
                }
                else
                {
                    countN++;
                }
                lst = lst.GetNext();
            }
            if (countP >= countN)
                return true;
            return false;
        }

        public static bool T5(IntNode lst, int n)
        {
            while (lst != null)
            {
                if (lst.GetValue() == n)
                {
                    return true;
                }
                lst = lst.GetNext();
            }
            return false;
        }

        public static bool T6(IntNode lst)
        {
            while (lst.GetNext() != null)
            {
                if (lst.GetValue() >= lst.GetNext().GetValue())
                {
                    lst = lst.GetNext();
                }
                else
                    return false;
            }
            return true;
        }

        public static int P76_2(IntNode lst, int n)
        {
            while(lst.GetValue != null)
            {

            }
        }
    }
}
