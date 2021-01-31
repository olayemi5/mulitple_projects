using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericArg
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopThroughTheList(23,23,23,23);
            LoopThroughTheList(new DateTime(2001, 12, 12).ToShortDateString(), new DateTime(1999,01,15).ToShortDateString(), new DateTime(2019,12,12).ToShortTimeString());
            LoopThroughTheList("Awoyaya", "Felele", new DateTime(2001,12,13).ToShortDateString());
         }

         public static void LoopThroughTheList<T>(params T[] names) 
         {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
                Console.WriteLine("-------------");
          }
    }
}
