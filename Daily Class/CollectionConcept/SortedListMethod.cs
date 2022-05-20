using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Daily_Class.CollectionConcept
{
    public class Stude:IComparable
    {
        string name;
        int perce;
        string city;

        public int CompareTo(object o)
        {
            Stude s2= (Stude)o;
            //return this.perce.CompareTo(s2.perce); //Ascending order of percentage
            //return s2.perce.CompareTo(this.perce);  //Descending order of percentage
            //return s2.name.CompareTo(this.name);  //Descending order of name
            return this.name.CompareTo(s2.name); //Ascending order of name
        }
        public Stude(string name, int perce, string city)
        {
            this.name = name;
            this.perce = perce;
            this.city = city;
        }
        public override string ToString()
        {
            return $"Name: {name} Percentage {perce} City {city}";
        }
        public string Name { get => name; set => name = value; }
        public int Perce { get => perce; set => perce = value; }
        public string City { get => city; set => city = value; }
    }
    internal class SortedListMethod
    {
        static void Main(string[] args)
        {
            //in sortedlist we always need same type of data in key
            //and in value not need same data we can write any string, int, etc
            //if we pass object then always need to inherit class to IComparable
            //for IComparable must needed method "CompareTo(object o)" bcoz its abstract method
            //not allowed duplicate key in sortedlist
            SortedList s =new SortedList();
            s.Add(new Stude("rohit", 89, "pune"), "java");
            s.Add(new Stude("shubham", 99, "mumbai"), "java");
            s.Add(new Stude("ketan", 78, "delhi"), 56.9);
            s.Add(new Stude("abhi", 85, "pune"), "java");
            
            foreach(DictionaryEntry d in s)
                Console.WriteLine(d.Key+" "+d.Value);

        }
    }
}
