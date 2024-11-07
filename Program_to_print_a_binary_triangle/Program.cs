using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_to_print_a_binary_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, lastInteger = 0, inputNum;
            Console.Write("Please enter the number of rows : ");
            inputNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputNum; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (lastInteger == 0)
                    {
                        Console.Write("0");
                        lastInteger = 1;
                    }
                    else if (lastInteger == 1)
                    {
                        Console.Write("1");
                        lastInteger = 0;
                    }
                }
                if (lastInteger == 0)
                {
                    lastInteger = 1;
                }
                else if (lastInteger == 1)
                {
                    lastInteger = 0;
                }
                Console.Write("\n");


            }
            Console.ReadLine();
        }
    }
}
