using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int d = 4;
            int[] result = rotLeft(a, d);
            foreach (var item in result)
            {
                Console.WriteLine($" {item.ToString()} ");
            }
            Console.ReadLine();
        }
        static int[] rotRight(int[] a, int d)
        {
            d = d % a.Length;

            //Complete Reverse
            //Reverse first d elements
            //Reverse the remaining d, a.Length-1 elements

            reverse(a, 0, a.Length - 1);
            reverse(a, 0, d);
            reverse(a, d + 1, a.Length -1);

            return a;
        }

        static int[] rotLeft(int[] a, int d)
        {
            int size = a.Length;
            int[] rotated_array = new int[size];
            int rotated_index = d;
            int i = 0;

            while(rotated_index < size)
            {
                rotated_array[i] = a[rotated_index];
                rotated_index++;
                i++;
            }

            rotated_index = 0;

            while(rotated_index < d)
            {
                rotated_array[i] = a[rotated_index];
                rotated_index++;
                i++;
            }
            //Complete Reverse
            //Reverse first d elements
            //Reverse the remaining d, a.Length-1 elements

            //reverse(a, 0, a.Length - 1);
            //reverse(a, 0, d);
            //reverse(a, d + 1, a.Length - 1);

            return rotated_array;
        }
        private static void reverse(int[] a, int start, int end)
        {
            while(start < end)
            {
                int temp = a[start];
                a[start] = a[end];
                a[end] = temp;
                start++;
                end--;
            }
        }
    }
}
