using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.OOPs
{
    class Country
    {
        string country_Name,capital_Name;
        int noOfStates, noOfLanguage;

        public string Countryname
        {
            get { return country_Name; }
            set { country_Name = value; }
        }
        public int Noofstates
        {
            get { return noOfStates; }
            set { noOfStates = value; }
        }
        public string Capitalname
        {
            set { capital_Name = value; }
            get { return capital_Name; }
        }
        public int Nooflanguage
        {
            set { noOfLanguage = value; }
            get { return noOfLanguage;}
        }
    }
    internal class SetGetPropertiy
    {
        static void Main(string[] args)
        {
            Country c=new Country();
            c.Countryname = "India";
            c.Capitalname = "Delhi";
            c.Noofstates = 28;
            c.Nooflanguage = 121;
            Console.Write($"Country Name \"{c.Countryname}\", Capital is \"{c.Capitalname}\"");
            Console.WriteLine($", No of States \"{c.Noofstates}\", No of Language is \"{c.Nooflanguage}\"");
        }
    }
}
