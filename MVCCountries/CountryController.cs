using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    internal class CountryController
    {
        List<Country> CountryDb = new List<Country>()
        {
            new Country("Sealand", "Europe", new List<string>(){"red", "white", "black"}),
            new Country("The Gay and Lesbian Kingdom of the Coral Sea Islands", "Oceania", new List<string>(){"red","orange", "yellow","green", "blue", "purple" }),
            new Country("Republic of Molossia", "North America", new List<string>(){"blue", "white", "green"}),

        };
        
        public void CountryAction(Country c)
        {
            new CountryView(c).Display();
        }

        public void WelcomeAction()
        {
            CountryListView c = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app.Please select a country from the following list:");
            bool runProgram = true;
            while (runProgram == true)
            {
                c.Display();
                bool isNumber = int.TryParse(Console.ReadLine(), out int userNumber);
                if (isNumber == true && userNumber >= 0 && userNumber < CountryDb.Count)
                {
                    CountryAction(CountryDb[userNumber]);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                runProgram = Validator.Validator.GetContinue("Would you like to learn about another country?");
            }
            
        }
    }
}
