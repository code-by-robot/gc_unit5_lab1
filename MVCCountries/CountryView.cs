using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    internal class CountryView
    {
        public Country DisplayCountry;
        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }
        public void Display()
        {
            Console.WriteLine($"{DisplayCountry.Name} is on {DisplayCountry.Continent}. Its colors are: ");
            foreach(string color in DisplayCountry.Colors)
            {
                Color.GetConsoleColor(color);
                Console.WriteLine(color);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
