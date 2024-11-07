using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_TwoNumbers_Without_using_Third_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1, second = 2;
            first= first + second;
            second = first - second;
            first= first - second;
            Console.WriteLine(first.ToString());
            Console.WriteLine(second.ToString());
            Console.ReadLine();
        }
    }
}
