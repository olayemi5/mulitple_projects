using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> Ask = ShowMessage;
           Ask("Stephen");

            Action<string> Name = delegate (string name) { Console.WriteLine("What is yout name " + name +"?"); };
            Name("Akinola");

            Action<string> Last = name => Console.WriteLine("What is your name " +name + "?");
            Last("Steve");
        }

        public static void ShowMessage(string name) 
        {
            Console.WriteLine("Hi how are you doing " + name + "?");
        }
    }
}
