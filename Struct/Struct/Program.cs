using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie();
            movie.Moviename = "Wild Tales";
            movie.Displayname(movie.Moviename);
            movie.rate = 8.1f;
            movie.Displayrate(movie.rate);
            movie.ReleaseDate = new DateTime (2019,08,01);
            movie.DisplayReleaseDate(movie.ReleaseDate);
            movie.languauges = languages.Hausa.ToString();
            movie.DisplayLanguages(movie.languauges);
            movie.countries1 = countries1.England.ToString();
            movie.countries2 = countries2.Nigeria.ToString();
            movie.DisplayCountry(movie.countries1,movie.countries2);
            movie.genre1 = Genres.Horror.ToString();
            movie.genre2 = Genres.Zombie.ToString();
            movie.genre3 = Genres.Adventure.ToString();
            movie.DisplayGenre(movie.genre1, movie.genre2, movie.genre3);
        }
    }

    struct Movie 
    {
        public string Moviename;
        public float rate;
        public DateTime ReleaseDate;
        public string genre1;
        public string genre2;
        public string genre3;
        public string languauges;
        public string countries1;
        public string countries2;



        public void Displayname(string name)
        {
            Console.WriteLine ("Movie :  \t " + name);
        }

        public void Displayrate(float name)
        {
            Console.WriteLine ("Rate  : \t " + name + " out of 10");
        }
        public void  DisplayReleaseDate(DateTime name)
        {
            Console.WriteLine("Release on :\t " + name);
        }

        public void DisplayLanguages(string name)
        {
            Console.WriteLine("Languages :   \t " + name);
        }

        public void DisplayCountry(string name, string name2)
        {
            Console.WriteLine("Movie : \t " + name +" "+ name2);
        }
        public void DisplayGenre(string name, string name2, string name3)
        {
            Console.WriteLine("Movie : \t " + name + " " + name2 + " " + name3);
        }


    }

     enum Genres 
     {
        Horror,
        Adventure,
        Thriller,
        Fantancy,
        Music,
        Zombie,
      }

      enum languages 
      {
        Yoruba,
        English,
        French,
        Hebrew,
        Hausa,
        Arabic,
        Igbo,
        TIVI
      }

      enum countries1 
      {
        England,
        Nigeria,
        Riwwanda,
        Ghana,
        Togo,
        America,
        London,
        Australlia
       }

    enum countries2
    {
        England,
        Nigeria,
        Riwwanda,
        Ghana,
        Togo,
        America,
        London,
        Australlia
    }


}
