using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            FourWheeled fourWheeled = new FourWheeled();
            fourWheeled.Capacity = "18";
            Console.WriteLine(fourWheeled.Capacity);
            fourWheeled.Drive();
        }
    }
    class Vehicle 
    {
        public string WheeledVehicle;
        public string NonwheeledVehicle;
     }

    class FourWheeled : Vehicle 
    {
        public string color;
        public string Manufacturer;
        public string MaxSpeed;
        public string Capacity;

        public void Start() 
        {
            Console.WriteLine("The car is starting");
         }
        public void Stop()
        {
            Console.WriteLine("The car is stopping");
        }
        public void Drive()
        {
            Console.WriteLine("The car is driving");
        }
        public void RunatMaxSpeed()
        {
            Console.WriteLine("The car is running at max speed");
        }

    }

    class TwoWheeled : Vehicle 
    {
        public string color;
        public string Manufacturer;
        public string MaxSpeed;
        public string Capacity;
    }
}
