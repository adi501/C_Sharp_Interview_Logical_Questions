using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "adi", b = "reddy";
            a=a+b; //adireddy
            b = a.Substring(0, a.Length - b.Length); //adi
            a = a.Substring(b.Length); //reddy
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
