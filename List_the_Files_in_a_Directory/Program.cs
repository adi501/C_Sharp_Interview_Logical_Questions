using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_the_Files_in_a_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Directory.GetFiles(@"D:\");
            Console.WriteLine("Files in the Directory");
            foreach (string name in array1)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
