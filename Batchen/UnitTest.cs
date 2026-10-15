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
    }
}
