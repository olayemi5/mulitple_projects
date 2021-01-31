using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTrainerEXE
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.Name = "Mission";

            Animal cat = new Animal();
            cat.Name = "Jerry";

            Animal sheep = new Animal();
            sheep.Name = "Lucy";

            Trainer trainer = new Trainer();
            trainer.TrainerName = "Steve";

            ArrayList array = new ArrayList();
            array.Add(dog);
            array.Add(cat);
            array.Add(sheep);
            array.Add(trainer);

            foreach (var item in array)
            {
                if (typeof(Animal) == item.GetType())
                {
                    ((Animal)item).SayHi();
                    ((Animal)item).Feed();
                }

                else
                    ((Trainer)item).SayHi();
            }
        }
    }

    struct Animal 
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

        public void Feed()
        {
            Console.WriteLine("{0} is feeding  \n", name);
        }

    }
    struct Trainer 
    {
        private string trainerName;

        public string TrainerName
        {
            get { return trainerName; }
            set { trainerName = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hi the new trainer's name is {0} ", TrainerName);
        }


    }
}
