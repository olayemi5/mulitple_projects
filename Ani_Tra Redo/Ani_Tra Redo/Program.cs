using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ani_Tra_Redo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals dog = new Animals();
            dog.Name = "Mission";

            Animals rabbit = new Animals();
            rabbit.Name = "Cherry";

            Animals lion = new Animals();
            lion.Name = "Simba";

            Trainers Jack = new Trainers();
            Jack.Trainername = "Jack moreyles";

            ArrayList list = new ArrayList();
            list.Add(dog);
            list.Add(rabbit);
            list.Add(lion);
            list.Add(Jack);

            foreach (var item in list)
            {
                if (typeof(Animals) == item.GetType())
                {
                    ((Animals)item).SayHi();
                    ((Animals)item).feed();
                }
                else
                    ((Trainers)item).SayHi();
                 
            }



        }
    }
    struct Animals 
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SayHi() 
        {
            Console.WriteLine("Hello my name is " + name);
         }
        public void feed() 
        {
            Console.WriteLine(name + " is eating");
         }


    }

    struct Trainers 
    {
        private string trainername;

        public string Trainername
        {
            get { return trainername; }
            set { trainername = value; }
        }

        public void SayHi() 
        {
            Console.WriteLine("Hello am the new trainer");
         }

    }
}
