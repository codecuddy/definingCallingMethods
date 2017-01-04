using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace definingCallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            GoodByeWorld();
            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            Console.WriteLine("hello world");
        }

        private static void GoodByeWorld()
        {
            Console.WriteLine("goodbye world");
        }
    }
}
