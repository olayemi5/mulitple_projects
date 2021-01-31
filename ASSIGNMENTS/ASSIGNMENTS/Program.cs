using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENTS
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, IntResult;
            double x, y, z, douResult;

            a = 4;
            b = 6;
            c = 3;
            IntResult = 0;

            x = 3.9d;
            y = 4.3d;
            z = 5.6d;
            douResult = 0;

            Console.WriteLine(PerformAdd(a,b));
            Console.WriteLine(PerformAdd(a,b,c));
            //for (int i = 0; i < 100; i++)
            //{
            //    if(i%2 == 0)
            //        Console.WriteLine(i);
            //}
            
            
            //for (int i = 10; i >= 1; i--)
            //{
            //    Console.WriteLine("0");
            //    for (int x = 10; x >= i; x--)
            //   {
            //        Console.Write("X");
            //   }
            //}
            
            
           // Console.WriteLine("Enter Value");
           // int x = 0;

           //int.TryParse(Console.ReadLine(),out  x);

           // if(x == 0)
           // Console.WriteLine("Invalid Input");
           // else
            

           // if (x % 2 == 0)
           //     Console.WriteLine(x + " This is an even number");
           // else
           //     Console.WriteLine(x + " This is a odd number");


            //Console.WriteLine("What is your name");
            //var input = Console.ReadLine();
            //Console.WriteLine("Nice to meet you {0} my name is C#. How old are you?",input);
            //int Ageinput = int.Parse(Console.ReadLine());
            //Console.WriteLine("{0} good. As for me I was born on 2002 which makes me 15 years old ",Ageinput);
        }

        static int PerformAdd(int num1, int num2) 
        {
            return num1 + num2;
         }

        static int PerformAdd(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}
