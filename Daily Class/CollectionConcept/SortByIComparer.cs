using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Daily_Class.CollectionConcept
{
    class Mysort:IComparer
    {
        public int Compare(object o1,object o2)
        {
            StringBuilder sb1=(StringBuilder)o1;
            StringBuilder sb2=(StringBuilder)o2;

            //return sb1.ToString().CompareTo(sb2.ToString()); //Ascending order 
            return sb2.ToString().CompareTo(sb1.ToString()); //Descending order
            
        }
    }
    internal class SortByIComparer
    {
        static void Main(string[] args)
        {
            //when we want sort by another inbuilt class like StringBuilder then
            //we need to create class is inherit to IComparer class 
            //and must needed "Compare(Object o1,Object o2)" method for sorting
            //bcoz method are abstract
            SortedList s=new SortedList(new Mysort());
            s.Add(new StringBuilder("ketan"),90);
            s.Add(new StringBuilder("vinya"),90);
            s.Add(new StringBuilder("abhi"),90);
            s.Add(new StringBuilder("rohit"),90);

            ArrayList a=new ArrayList();
            a.Add(new StringBuilder("ram"));
            a.Add(new StringBuilder("laxman"));
            a.Add(new StringBuilder("sita"));
            a.Add(new StringBuilder("hanuman"));
            a.Sort(new Mysort());

            foreach(DictionaryEntry d in s)
                Console.WriteLine(d.Key +" "+d.Value);
            Console.WriteLine();
            foreach(var v in a)
                Console.WriteLine(v);
        }
    }
}
