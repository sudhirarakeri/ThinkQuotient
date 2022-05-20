using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Daily_Class.CollectionConcept
{
    class Stu:IComparable<Stu>
    {
        string name;
        int perc;

        public string Name { get => name; set => name = value; }
        public int Perc { get => perc; set => perc = value; }

        public int CompareTo(Stu s)
        {
            return Name.CompareTo(s.Name);
        }
        public Stu(string name, int perc)
        {
            this.Name = name;
            this.Perc = perc;
        }
        public override string ToString()
        {
            return $"name : {Name} perc = {Perc}";
        }
    }
    class SortStuPerc : IComparer<Stu>
    {
        public int Compare(Stu? x, Stu? y)
        {
            return x.Perc.CompareTo(y.Perc);
        }
    }
    internal class SortedListNonGeneric
    {
        static void Main(string[] args)
        {
            SortedList<Stu,string> list = new SortedList<Stu,string>(new SortStuPerc());
            list.Add(new Stu("dhoraj", 89), "java");
            list.Add(new Stu("kumar", 79), "C#");
            list.Add(new Stu("ravi", 58), "java");

            foreach(KeyValuePair<Stu,string> d in list)
                Console.WriteLine(d.Key+" "+d.Value);
        }
    }
}
