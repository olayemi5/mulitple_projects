using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar
{
    class Program
    {
        static void Main(string[] args)
        {
            Country countryOneInstance = new Country();
            Country countryTwoInstance = new Country();
            countryOneInstance.CountryLanguage = Languages.English.ToString();
            countryTwoInstance.CountryLanguage = Languages.Hebrew.ToString();
            countryOneInstance.PlanetName = "Earth";
             var Countrylanguage = countryOneInstance.CountryLanguage;
            countryOneInstance.CountryName = "Nigeria";
            countryOneInstance.Currency = Currencies.Dollar.ToString();
            countryOneInstance.CountryLanguage = Languages.Youruba.ToString();
            countryOneInstance.SayHi(countryOneInstance.CountryName);


        }
    }
    class World 
    {
        private string planetName;

        public string PlanetName
        {
            get { return planetName; }
            set { planetName = value; }
        }

        private string continents;

        public string Continents
        {
            get { return continents; }
            set { continents = value; }
        }


    }

    enum Continents 
    {
        Africa,
        Australlia,
        Europe,
        Anthratica,
        SouthAmerica,
        Asia,
        NorthAmerica
     }

    enum Currencies
    {
        Naira,
        Kobo,
        Rands,
        Cowalt,
        Kobalts,
        Dollar,
        Cephas
    }

    enum Languages
    {
        French,
        Hebrew,
        English,
        Arabic,
        Youruba,
        Indian,
        Hausa
    }

    class Country : World
    {
        private string countryName;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        private string capital;

        public string countryCapital
        {
            get { return capital; }
            set { capital = value; }
        }

        private string countryLanguage;

        public string CountryLanguage
        {
            get { return countryLanguage; }
            set { countryLanguage = value; }
        }

        private string currency;

        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public Country() 
        {
            CountryName = "Unkown";
            capital = "Unkown";
        }

        public void SayHi() 
        {
            Console.WriteLine("Hi!");
         }
        public void SayHi(string countryName)
        {
            Console.WriteLine("Hi! " + CountryName);
        }

    }

    struct Countrylanguage 
    {
        private string firstLanguage;

        public string FirstLanguage
        {
            get { return firstLanguage; }
            set { firstLanguage = value; }
        }

        private string secondLanguages;

        public string SecondLanguages
        {
            get { return secondLanguages; }
            set { secondLanguages = value; }
        }


    }
}
