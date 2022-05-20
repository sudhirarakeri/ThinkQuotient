using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Home_Work.Collection_Test2
{
    class Emp:IComparable<Emp>
    {
        string name;
        int sal;

        public int CompareTo(Emp o)
        {
            return this.name.CompareTo(o.name);
        }
        public Emp(string name, int sal)
        {
            this.name = name;
            this.sal = sal;
        }
        public override string ToString()
        {
            return $"Name : {name} Salary {sal}";
        }
    }
    internal class Que7
    {
        static void Main(string[] args)
        {
            SortedList<Emp, string> sl = new SortedList<Emp, string>();
            sl.Add(new Emp("kiran", 67000), "Java");
            sl.Add(new Emp("vaibhav", 47000), "C#");
            sl.Add(new Emp("ram", 7000), "Python");
            sl.Add(new Emp("dharun", 6000), "Java");

            foreach(var s in sl)
                Console.WriteLine(s);
        }
    }
}
