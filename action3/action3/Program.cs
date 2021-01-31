using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace action3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Func<string, string> FunOne = ToUpper;
            Console.WriteLine("From func");
            Console.WriteLine(FunOne("olayemi nixon \n"));

            Func<string, string> FunTwo = delegate (string name) { return name.ToUpper(); };
            Console.WriteLine("USing Anonymous");
            Console.WriteLine(FunTwo("olayemi stephen \n"));

            Func<string, string> FunThree = name => name.ToUpper();
            Console.WriteLine("Using Lamba");
            Console.WriteLine(FunThree("Akiola olayemi \n"));


        }

        public static string ToUpper(string name) 
        {
            return name.ToUpper();
        }
    }
}
