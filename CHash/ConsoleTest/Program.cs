using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            int[] b = a;
            b[0] = 55;
            Console.WriteLine("Object a");
            for(int i =0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine("Object b");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
