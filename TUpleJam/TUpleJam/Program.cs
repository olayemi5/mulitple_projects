using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUpleJam
{
    class Program
    {
        static void Main(string[] args)
        {
            var EmployerInfo = new List<Tuple<int, string,string, decimal ,bool>>();
            EmployerInfo.Add(Tuple.Create(32, "Mark", "Fish", 5466m, true));
            EmployerInfo.Add(Tuple.Create(32, "Mish", "Saw", 50000m, false));
            EmployerInfo.Add(Tuple.Create(12, "Luke", "Milk", 60000m, true));
            EmployerInfo.Add(Tuple.Create(42, "Rave", "Jackson", 70000m, false));
            EmployerInfo.Add(Tuple.Create(72, "Dave", "Marshal", 80000m,true));

            foreach (var item in EmployerInfo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("After Sorting");
            EmployerInfo.Sort();
            foreach (var item in EmployerInfo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("After Reverse");
            EmployerInfo.Reverse();
            foreach (var item in EmployerInfo)
            {
                Console.WriteLine(item);
            }

        }
    }
}
