using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGround
{
    class Program
    {
        static void Main(string[] args)
        {
            string greenColor = "This is a GREEN message";
            string redColor = "This is a RED message";
            string blueColor = "This is a BLUE message";

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(greenColor);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(redColor);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(blueColor);
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ForegroundColor = ConsoleColor.White;



        }
    }
}
