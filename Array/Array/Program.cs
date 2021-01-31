using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add("First");
            array.Add("Second");
            array.Add(3);
            array.Add(4.5d);

            foreach (var item in array)
            {
                Console.WriteLine(item);
                
            }
            array.Insert(2, "Third");
            foreach (var item in array)

            {
                Console.WriteLine("item");    
            }
            

        }
    }
}
