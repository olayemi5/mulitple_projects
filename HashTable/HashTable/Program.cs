using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            hash.Add("BIGI","NIGERIA");
            hash.Add("FOODCO","NIGERIA");
            hash.Add("KFC" , "CHINA");

            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.WriteLine("Count is: "+ hash.Count);
            Console.WriteLine("-----------------");
            Console.WriteLine("After removing");
           hash.Remove("KFC");
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
