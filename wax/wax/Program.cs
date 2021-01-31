using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regain
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(x.IsGreater(10));
        }
    }

    static class MyExtension
    {
        public static bool IsGreater(this int value, int number)
        {
            return value > number;
        }
    }
}
