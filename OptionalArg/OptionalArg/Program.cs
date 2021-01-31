using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalArg
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayPlayerInfomation(no:7, name:"Ronaldo", goals:65);
            //Console.WriteLine( "---------------------");
            //DisplayPlayerInfomation(10, "Messi", 34);

        }

       static void  DisplayPlayerInfomation(int no, string name, int goals, string country = "Unkown", string club = "Unknown")
        {
            Console.WriteLine("Hi from the first method");
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
            Console.WriteLine(country);
            Console.WriteLine(club);

        }
        //static void DisplayPlayerInfomation(int no, string name, int goals)
        //{
        //    Console.WriteLine("Hi from overload");
        //    Console.WriteLine(no);
        //    Console.WriteLine(name);
        //    Console.WriteLine(goals);
           

        //}
    }

}