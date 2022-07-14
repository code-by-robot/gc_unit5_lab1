using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    internal class Color
    {
        public string Hue { get; set; }
        public Color(string _hue)
        {
            Hue = _hue;
        }

        public static void GetConsoleColor(string color)
        {
            if (color.ToLower().Trim() == "red")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (color.ToLower().Trim() == "orange")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (color.ToLower().Trim() == "yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (color.ToLower().Trim() == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (color.ToLower().Trim() == "blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (color.ToLower().Trim() == "purple")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (color.ToLower().Trim() == "black")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }
            else if (color.ToLower().Trim() == "white")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
