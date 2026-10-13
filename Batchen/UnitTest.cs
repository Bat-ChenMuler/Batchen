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

            IntNode n1 = new IntNode(-17);
            IntNode n = new IntNode(17, n1);
            n1 = null;

            Console.WriteLine(Print(n));
            Console.WriteLine(n.GetValue);
        }
        public static void Test1()
        {
            IntNode n2 = new IntNode(51);
            IntNode n1 = new IntNode(3, n2);
            IntNode n = new IntNode(42,n1);
            n2 = null;
            n1 = null;

            //Console.WriteLine(n1);
            //Console.WriteLine(n);
            //Console.WriteLine(n.GetNext());

            n.GetNext().GetNext().SetNext(new IntNode(99));
            n.GetNext().GetNext().SetNext(null);

            bool b = true;
            IntNode temp = n;
            while(b)
            {
                Console.WriteLine(temp);
                temp = temp.GetNext();
                if (temp == null)
                    b = false;
            }
        }

        public static string Print(IntNode lst)
        {
            string s = "-->";
            bool b = true;
            IntNode temp = lst;
            while(b)
            {
                s += lst.ToString() + "-->";
                temp = temp.GetNext();
                if (temp == null)
                    b = false;
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
    }
}
