using System;
using System.Collections;
using System.Collections.Generic;

namespace praktic4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,2
            ArrayList kol = new ArrayList() { 1, 2, 8, 7, 'e', 'j', 'P', 786, 1243, 9789, 2342, 'R', 'U', 3212, 98 };
            string a1 = "";
            for (int i = 0; i < kol.Count; i++)
            {
                a1 = a1 + kol[i] + ", ";
            }
            Console.WriteLine("1,2) " + a1);
            //3
            ArrayList kol1 = new ArrayList() { 1, 2, 8, 7, 'e', 'j', 'P', 786, 1243, 9789, 2342, 'R', 'U', 3212, 98 };
            string a2 = "";
            string a3 = "";
            foreach (var i in kol1)
            {
                Type t = i.GetType();
                if (t.Equals(typeof(int)) == true)
                {
                    a2 = a2 + i + ", ";
                }
                if (t.Equals(typeof(int)) == false)
                {
                    a3 = a3 + i + ", ";
                }
            }
            Console.WriteLine("3) " + a2);
            //4
            ArrayList kol2 = new ArrayList();
            string a4 = "";
            for (int i = 0; i < a3.Length; i++)
            {
                if (Char.IsUpper(a3[i]) == true)
                {
                    kol2.Add(a3[i]);
                }
            }
            for (int i = 0; i < kol2.Count; i++)
            {
                a4 = a4 + kol2[i] + ", ";
            }
            Console.WriteLine("4) " + a4);
        }
    }
}