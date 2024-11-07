using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Merge_two_arrays_and_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 1, 2 };
            int[] B = { 4, 6, 5 };
            int[] c = a.Concat(B).ToArray();
            Array.Sort(c);
            foreach (int i in c)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
