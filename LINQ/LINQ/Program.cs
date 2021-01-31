using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {


            Helper helper = new Helper();
            Thread ts = new Thread(new ParameterizedThreadStart(Helper.Loop));
            ts.Start(10);

           

        }

    }

    class Helper 
    {
        public static void Loop(object number) 
        {
            for (int i = 0; i < int.Parse( number.ToString()); i++)
            {
                Console.WriteLine(i);
            }
        } 
    }
}
