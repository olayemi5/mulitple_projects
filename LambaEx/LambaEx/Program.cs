using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambaEx
{
    delegate void DisplayInfo();
    delegate int MultiplyNumber(int y);
     
    class Program
    {
        static void Main(string[] args)
        {
           List<int> StuckLIst = new List<int>();
            StuckLIst.Add(32); StuckLIst.Add(17); StuckLIst.Add(13); StuckLIst.Add(72); StuckLIst.Add(15); StuckLIst.Add(34);
            StuckLIst.Add(12); StuckLIst.Add(14); StuckLIst.Add(37); StuckLIst.Add(129); StuckLIst.Add(89); StuckLIst.Add(93);

            var Oddlist = StuckLIst.Where(n => n % 2 != 0).ToList();
            var EvenLst = StuckLIst.Where(n => n % 2 == 0).ToList();

            Console.WriteLine("Odd list loading.............");
            foreach (var stuck in Oddlist)
            {
                Console.WriteLine(stuck);
            }

            Console.WriteLine("Even list loading.............");
            foreach (var stuck in EvenLst)
            {
                Console.WriteLine(stuck);
            }
        }
    }
}
