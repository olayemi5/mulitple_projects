using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AnimalEXE
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
            dog.Name = "Rott";

            List<Animals> list = new List<Animals>();

            list.Add(cat);
            list.Add(rat);
            list.Add(dog);

            foreach (var item in list)
            {
               ((Animals)item).SayHi();
                ((Animals)item).feed();

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
            Console.WriteLine("Hi my name is {0}", name);
         }

        public void feed()
        {
            Console.WriteLine("Hi my {0} is feeding \n", name);
        }

    }
}
