using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string givenString = "abcba";
            string reverse = "";
            for (int i = givenString.Length; i >0; i--)
            {
                reverse += givenString[i-1];
            }
            if (givenString == reverse)
            {
                Console.WriteLine("String is a palindrome \n");
            }
            else
            {
                Console.WriteLine("String not is a palindrome \n");
            }
        }
    }
}
