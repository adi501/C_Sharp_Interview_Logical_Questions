using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keywords_Virtual_Override_New_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            parent objp = new parent();
            objp.Method1();
            objp.Method2();
            objp.Method3();

            Console.WriteLine("==================");

            child objc = new child();
            objc.Method1();
            objc.Method2();
            objc.Method3();

            Console.WriteLine("==================");
            parent objpc = new child();
            objpc.Method1();
            objpc.Method2();
            objpc.Method3();

           

            Console.ReadLine();

        }

       
    }
    public class parent
    {
        public void Method1()
        {
            Console.WriteLine("Parent Method1");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Parent Method2");
        }
        public virtual void Method3()
        {
            Console.WriteLine("Parent Method3");
        }
    }
    public class child:parent
    {
        public void Method1()
        {
            Console.WriteLine("child Method1");
        }
        public override void Method2()
        {
            Console.WriteLine("child Method2");
        }
        public new void Method3()
        {
            Console.WriteLine("child Method3");
        }
    }
}
