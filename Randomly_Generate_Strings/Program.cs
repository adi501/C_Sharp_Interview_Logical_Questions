using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomly_Generate_Strings
{
    static class Random
    {
        public static string GetRandomString()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", "");
            return path;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Random.GetRandomString());
            Console.WriteLine(Random.GetRandomString());
            Console.WriteLine(Random.GetRandomString());
            Console.Read();
        }
    }
}
