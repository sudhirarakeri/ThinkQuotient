using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Daily_Class.CollectionConcept
{
    internal class ArraylistMethod
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add("Sudhir");
            a.Add("po");
            a.Insert(1, "a");
            a.Remove(3);
            a.Reverse();
            Console.WriteLine(a.IndexOf("a"));
            for(int i = 0; i < a.Count; i++)
                Console.WriteLine(a[i]);
            Console.WriteLine();
            foreach(var i in a)
                Console.WriteLine(i);
        }

    }
}
