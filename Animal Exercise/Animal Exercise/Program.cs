using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Animal_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Animals();
            cat.Name = "Tom";

            Animals rat = new Animals();
            rat.Name = "Jerry";

            Animals dog = new Animals();
            dog.Name = "Max";

            List<Animals> list = new List<Animals>();
            list.Add(cat);
            list.Add(rat);
            list.Add(dog);

            foreach (var item in list)
            {
                item.SayHi();
                item.feed();
            }
        }
    }

    class Animals 
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SayHi() 
        {
            Console.WriteLine("Hello my name is {0} ",name);
         }

         public void feed() 
         {
            Console.WriteLine("Hi {0} is eating ",name);
          }

    }
}
