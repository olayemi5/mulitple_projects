using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace trail
{
    class Program
    {
        static void Main(string[] args)
        {
            string countries = "";
            int count = Enum.GetNames(typeof(Countries)).Length;
            for (int i = 0; i < count; i++)
            {
                countries = Enum.GetValues(typeof(Countries)).GetValue(i).ToString();
                Console.WriteLine(countries);
                Directory.CreateDirectory(@"C:\Countries");
                Directory.CreateDirectory(@"C:\Countries\" + countries);
                StreamWriter sw = new StreamWriter(@"C:\Countries\" + countries + "\\log.txt");
                sw.WriteLine("File no " + i + " file created on " + DateTime.Now);
                sw.Close();
            }

        }
    }
    enum Countries
    {
        Canada,
        USA,
        Australlia,
        Germany,
        Morocco,
        Nigeria,
        NewYork,
        Mosco,
        Dubia,
        Russia,
        Isreal,
        Ghana,
        Egypt,
    }

}
