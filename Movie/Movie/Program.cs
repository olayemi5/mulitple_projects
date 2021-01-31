using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie<double,DateTime>> movieList = new List<Movie<double,DateTime>>();
            List<Movie<float, int>> secondList = new List<Movie<float, int>>();

            var Merlin_2 = new Movie<float, int>();
            Merlin_2.Name = "The Fall of the Castle";
            Merlin_2.Director = "Jack Bow";
            Merlin_2.Rate = 8.7f;
            Merlin_2.Release_date = 2005;

            var lordoftheRings2 = new Movie<float, int>();
            lordoftheRings2.Name = "The Nightmare";
            lordoftheRings2.Director = "Bawa Toss";
            lordoftheRings2.Rate = 9.7f;
            lordoftheRings2.Release_date = 2006;

            var Saw2 = new Movie<float, int>();
            Saw2.Name = "Horror Legacy";
            Saw2.Director = "Peters Moysce";
            Saw2.Rate = 7.9f;
            Saw2.Release_date = 2007;


            Movie<double, DateTime> Merlin_1 = new Movie<double, DateTime>();
            Merlin_1.Name = "The Strike of Camelot";
            Merlin_1.Director = "Steve Sega";
            Merlin_1.Rate = 8.9;
            Merlin_1.Release_date = new DateTime(2001,01,01); 

            Movie<double, DateTime> lordoftheRings1 = new Movie<double, DateTime>();
            lordoftheRings1.Name = "The Fellowship of the Ring";
            lordoftheRings1.Director = "Abraham Loncon";
            lordoftheRings1.Rate = 9.34;
            lordoftheRings1.Release_date = new DateTime(1999,12,12);

            Movie<double, DateTime> Saw1 = new Movie<double, DateTime>();
            Saw1.Name = "The Vengance";
            Saw1.Director = "Alisha kee";
            Saw1.Rate = 6.0;
            Saw1.Release_date = new DateTime(2012, 12 ,12);

            movieList.Add(Saw1);
            movieList.Add(lordoftheRings1);
            movieList.Add(Merlin_1);

            secondList.Add(Merlin_2);
            secondList.Add(lordoftheRings2);
            secondList.Add(Saw2);
           
        }
    }
    class Movie<T, U> 
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

        private U release_date;

        public U Release_date
        {
            get { return release_date; }
            set { release_date = value; }
        }

        public void Say() 
        {
           
            Console.WriteLine("Movie Name " + name);
         }



    } 
}
