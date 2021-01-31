using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Optional_Arg
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayPlayerInfo(23, "Ronaldo", 54, "Portugal","Juventus");
            Console.WriteLine("------------------");
            DisplayPlayerInfo(32, "Messi", 45);
            Console.WriteLine("------------------");
            DisplayPlayerInfo(no: 34, name: "Jerrad", goals:99, club:"Liverpool");
        }

        public static void DisplayPlayerInfo(int no, string name, int goals, string country ="Unknown", string club ="Unkown") 
        {
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
            Console.WriteLine(country);
            Console.WriteLine(club);
         }
        public static void DisplayPlayerInfo(int no, string name, int goals)
        {
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
           
        }

    }
}
