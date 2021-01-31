using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movies<double, DateTime>> firstlist = new List<Movies<double, DateTime>>();

            Movies<double, DateTime> lordoftheRings1 = new Movies<double, DateTime>();
            lordoftheRings1.Name = "Assembly of the fellowship";
            lordoftheRings1.Director = "Steve Jaw";
            lordoftheRings1.Rate = 8.3;
            lordoftheRings1.ReleaseDate = new DateTime(2001,12,12);

            Movies<double, DateTime> lordoftheRings2 = new Movies<double, DateTime>();
            lordoftheRings2.Name = "Forecast";
            lordoftheRings2.Director = "Steve Jaw";
            lordoftheRings2.Rate = 8.3;
            lordoftheRings2.ReleaseDate = new DateTime(2003, 12, 12);


            List<Movies<float, int>> Secondlist = new List<Movies<float, int>>();

            Movies<float, int> Darknight1 = new Movies<float, int>();
            Darknight1.Name = "The DarkKnight";
            Darknight1.Director = "Classic saw";
            Darknight1.Rate = 5.67f;
            Darknight1.ReleaseDate = 2019/12/12;

            Movies<float, int> Darknight2 = new Movies<float, int>();
            Darknight2.Name = "The DarkKnight";
            Darknight2.Director = "Classic saw";
            Darknight2.Rate = 6.72f;
            Darknight2.ReleaseDate = 2001 /01/01;


            firstlist.Add(lordoftheRings1);
            firstlist.Add(lordoftheRings2);
            Secondlist.Add(Darknight1);
            Secondlist.Add(Darknight2);

            foreach (Movies<double,DateTime> item in firstlist)
            {
                Console.WriteLine(Darknight2.ReleaseDate);
            }
        }
    }

    class Movies<T, Z> 
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        private T rate;

        public T Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        private Z releaseDate;

        public Z ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        public void SayHi() 
        {
            Console.WriteLine("Hi this is a call msg.");
         }


    }
}
