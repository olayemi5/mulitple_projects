using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals.Add("Nigeria","Abuja");
            capitals.Add("Eygpt", "Cairo");
            capitals.Add("Canada", "Toronto");
            capitals.Add("America", "London");
            capitals.Add("Lagos", "Ikeja");

            //foreach (var item in capitals)
            //{
            //    Console.WriteLine(item.Key);
            //}
            for (int i = 0; i < capitals.Count; i++)
            {
                Console.WriteLine(capitals.Keys.ElementAt(i));
            }
            Console.WriteLine("-------------");
            capitals["Lagos"] = "Ibadan";
            Console.WriteLine(capitals["Lagos"]);

            string result;
            capitals.TryGetValue("Moscoe", out result);
            if(result == null)
                Console.WriteLine("Input not on list");
            else
            Console.WriteLine("Result is "+result);
        }

    }
}
