using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mercedes = new Mercedes();
            mercedes.DisplayInfo();
        }
    }

    class car 
    {
        private decimal price;
        public string color;
        protected int Maxspeed;

        public decimal Price 
        {
            get { return price; }
            set { price = value; }
         }
       
         public virtual void DisplayInfo() 
         {
            price = 1000;
            Maxspeed = 300;
            color = "Black";

            Console.WriteLine("Default Price: " + price + " and color is " + color + " and Maxspeed is " + Maxspeed);
          }

     }

     class Mercedes : car
     {
        public override void DisplayInfo()
        {

            base.DisplayInfo();
            base.color = "Grey";
            base.Maxspeed = 440;
            base.Price = 15000;
            

            Console.WriteLine("Overriden Value: " + Price + " and color is " + color + " and Maxspeed is " + Maxspeed);
        }
    }

}
