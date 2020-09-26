using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            ReverseArray(a);
        }

        private static void ReverseArray(int[] a)
        {
            Array.Reverse(a);
            Array.ForEach(a, (x) => { Console.Write(x + " "); });
            Console.ReadLine();
        }
    }
}
