using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Country countryOne = new Country();
            countryOne.Countryname = "Nigeria";
            countryOne.PlanetName = Planet.Earth.ToString();
            countryOne.Countinents = continents.Africa.ToString();
            countryOne.Languages = Languages.Yoruba.ToString();
            //countryOne.Languages = Languages.Hausa.ToString();
            countryOne.Languages = Languages.Igbo.ToString();
            countryOne.Capital = "Abuja";
            countryOne.Currency = currencies.Naira.ToString();
            //countryOne.DisplayMessage();
            //countryOne.DisplayMessage(countryOne.Countryname, countryOne.PlanetName, countryOne.Countinents, countryOne.Languages, countryOne.Capital, countryOne.Currency);
            Console.WriteLine("What your veiw on that Project");
            var Result = Console.ReadLine();
            Console.WriteLine("You have used " + Result.Length+ " Characrters and have "+ (140-Result.Length) +" Chareacters left");
        }
    }

    class world 
    {
        private string planetName;

        public string PlanetName
        {
            get { return planetName; }
            set { planetName = value; }
        }

        private string continent;

        public string Countinents
        {
            get { return continent; }
            set { continent = value; }
        }



    }

     class Country : world 
     {
        private string countryname;

        public string Countryname
        {
            get { return countryname; }
            set { countryname = value; }
        }
        private string capital;

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        private string languages;

        public string Languages
        {
            get { return languages; }
            set { languages = value; }
        }

        private string currency;

        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public Country() 
        {
            countryname = "Unknown";
            capital = "Unknown";
         }

         public void DisplayMessage() 
         {
            Console.WriteLine("Hi! This are few Infomation About me ");
          }

        public void DisplayMessage(string name, string planet, string continents, string languages, string capital, string currency)
        {
            Console.WriteLine("{0} is my Country from planet {1} and continents {2} we have three major languages which are {3}  the capital of {0} is {4} and we spend {5} as major source of financial exchange ", name, planet,continents,languages,capital,currency);
        }
     }
     public struct languages 
     {
        public string firstLang;
        public string secondLang;
      }

      enum continents 
      {
        Africa,
         Australlia,
          Europe,
           Anthractica,
            SouthAmerica,
             Asia,
              NothAmerica
       }

    enum currencies
    {
        Naira,
           Kobo,
              Pounds,
                 Sterling,
                    Cowait,
                        Dollar,
                            Cephas,
                                Rands,
                                     Coins,

    }
    enum Languages
    {
        Yoruba,
        Hausa,
        Igala,
        Igbo,
        TIV,
        Egbira,
        Zulu,
        English,
        French,
        Hebrew

    }

    enum Planet 
    {
        Earth,
        Mercury,
        Mars,
        Jupitar,
        Venus,
        Sarturn,
        Pluto,

     }

}
