using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples_Exe
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeInfo = new List<Tuple<int, string, string, string, DateTime>>();
            employeeInfo.Add(Tuple.Create(1, "Whales", "Pop", "Ass.Manager", new DateTime(2001,12,12)));
            employeeInfo.Add(Tuple.Create(3, "Shark", "Fins", "Manager", new DateTime(2000, 01, 01)));
            employeeInfo.Add(Tuple.Create(2, "Whales", "Pop", "Mar.Manager", new DateTime(2000, 11, 10)));
            employeeInfo.Add(Tuple.Create(4, "Whales", "Pop", "Accountant", new DateTime(2003, 02, 05)));
            employeeInfo.Add(Tuple.Create(0, "Whales", "Pop", "Gen.Sec", new DateTime(2006, 11, 01)));

            Console.WriteLine("Before Sorting");
            foreach (var employee in employeeInfo)
            {
                Console.WriteLine($"{employee.Item1} {employee.Item2} {employee.Item3} {employee.Item4} {(DateTime)(employee.Item5)}.");
            }

            Console.WriteLine("\n After Sorting");
            employeeInfo.Sort();
            foreach (var employee in employeeInfo)
            {
                Console.WriteLine($"{employee.Item1} {employee.Item2} {employee.Item3} {employee.Item4} {(DateTime)(employee.Item5)}.");
            }

            Console.WriteLine("\n After Reverse");
            employeeInfo.Reverse();
            foreach (var employee in employeeInfo)
            {
                Console.WriteLine($"{employee.Item1} {employee.Item2} {employee.Item3} {employee.Item4} {(DateTime)(employee.Item5)}.");
            }
        }
    }
}
