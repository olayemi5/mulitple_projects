using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace kIM
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            Console.WriteLine("Before insertion");
            array.Add("John");
            array.Add("Olayemi");
            array.Add("27");
            array.Add("2010");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
            Console.WriteLine("After insertion");
            array.Insert(2, "Unknown");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------");
            Console.WriteLine(array[1]);

            Console.WriteLine("-----------");
            Console.WriteLine("Count is "+ array.Count);

            Console.WriteLine("-----------");
            array.Sort();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------");
            Console.WriteLine("After Inversion");
            array.Reverse();
            foreach (var item in array)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("-----------");
            Console.WriteLine("After removing");
            //   array.Remove("Unknown");
            array.RemoveAt(2);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------");
            Console.WriteLine("After removing all");
            //array.Clear();
            array.RemoveRange(1,2 );
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------");
            Console.WriteLine("After asking if contain");
            Console.WriteLine(array.Contains("John"));

            Console.WriteLine("-----------");
            Console.WriteLine("After getting range" );
            ArrayList names = new ArrayList();
            names = array.GetRange(0, 2);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
