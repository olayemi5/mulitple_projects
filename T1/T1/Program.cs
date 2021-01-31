using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Jeniffer = Tuple.Create(54, "Jennifer","Moees", 45000m, true );
            DisplayInfo(Jeniffer);
            Console.WriteLine("---------------------------");
            var Makinde = Tuple.Create(65, "Makinde", "Ezekiel", 6000000000m, true);
            DisplayInfo(Makinde);
            Console.WriteLine("---------------------------");
            Console.WriteLine(GetInfo().Item1);
            Console.WriteLine(GetInfo().Item2);
            Console.WriteLine(GetInfo().Item3);
            Console.WriteLine(GetInfo().Item4);
            Console.WriteLine(GetInfo().Item5);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Price for standard maggi");
            Console.WriteLine(Standard_Price().Item1);
            Console.WriteLine(Standard_Price().Item2);
            Console.WriteLine(Standard_Price().Item3);
            Console.WriteLine(Standard_Price().Item4);
            Console.WriteLine(Standard_Price().Item5);
            Console.WriteLine(Standard_Price().Item6);
           
        }

        public static void DisplayInfo(Tuple<int, string,string,decimal, bool> Personalinfo) 
        {
            Console.WriteLine(Personalinfo.Item1);
            Console.WriteLine(Personalinfo.Item2);
            Console.WriteLine(Personalinfo.Item3);
            Console.WriteLine(Personalinfo.Item4);
            Console.WriteLine(Personalinfo.Item5);

        }

        public static Tuple<int, string, string, decimal,bool> GetInfo()
        {
            var Info = Tuple.Create(54, "Margret","Jackson", 5600000m, false);

            return Info;
        }

        public static Tuple<int, bool, string, string, decimal, int>Standard_Price() 
        {
            var Standard = Tuple.Create(43, true, "Maggi", "Super", 5000m, 12);

            return Standard;
         }
    }
}
