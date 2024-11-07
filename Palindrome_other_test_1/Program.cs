using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_other_test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<1000;i++)
            {
                string numbers = i.ToString();
                int[] intArray = new int[numbers.Length];
                for (int j = 0; j < numbers.Length; j++)
                {
                    intArray[j] = int.Parse(numbers[j].ToString());
                }
                if (intArray.Length > 1)
                {
                    bool areEqual = intArray.GroupBy(s => s).Count() == 1;
                    if(areEqual==true)
                    {
                       // Console.WriteLine(i);
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                   Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
