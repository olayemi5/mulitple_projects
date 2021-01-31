using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast
{
    public delegate T DisplayInfo<T>(T value);
    public delegate void DisplayInf(float number);
    class Program
    {
    
        static void Main(string[] args)
        {
            DisplayInfo<int> phonenumber = new DisplayInfo<int>(DisplayValue);
            Console.WriteLine(phonenumber(100));

            DisplayInfo<double> Phoneprice = new DisplayInfo<double>(DisplayValue);
            Console.WriteLine(Phoneprice(233332));

            DisplayInf Rate = delegate (float number) { Console.WriteLine ("Series rate loading.........."+ number); };
            Rate(7.39f);
        }
        
        public static T DisplayValue<T>(T value) 
        {
            Console.WriteLine("Hey you are about to access your data..........." );
            return value; 
        }
    }
}
