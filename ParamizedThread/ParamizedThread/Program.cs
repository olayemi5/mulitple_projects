using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParamizedThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper help = new Helper();

            Thread ts = new Thread(new ParameterizedThreadStart(help.Loop));
            ts.Start(20);
           
        }
    }

    class Helper 
    {

        

        public void Loop (object number) 
        {
            for (int i = 0; i < int.Parse(number.ToString()); i++)
            {
                Console.WriteLine(i);
            } 
        } 
    }
}
