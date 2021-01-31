using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Animal_Trainer_Exercise
{
    class Program
    {
            static void Main(string[] args)
        {

            Animals dog = new Animals();
            dog.Name = "Mission";

            Animals cat = new Animals();
            cat.Name = "Tom";

            Animals sheep = new Animals();
            sheep.Name = "Mesh";

            Trainers John = new Trainers();
            John.TrainerName = "John Jackson";

            ArrayList list = new ArrayList();
            list.Add(dog);
            list.Add(cat);
            list.Add(sheep);
            list.Add(John);
            

            foreach (var item in list)
            {
                if(typeof(Animals) == item.GetType()) { 
                         ((Animals)item).SayHi();
                        ((Animals)item).Feed();
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
            Console.WriteLine("Hello my name is: " + name);
         }
        public void Feed()
        {
            Console.WriteLine(name + " is eating now");
        }
    }

    struct Trainers 
    {
        private string trainerName;

        public string TrainerName
        {
            get { return trainerName; }
            set { trainerName = value; }
        }
        public void SayHi()
        {
            Console.WriteLine("Hello I am the new trainer");
        }

    }
}
