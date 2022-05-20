using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Daily_Class.CollectionConcept
{
    internal class HashSetMethod
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> {"A", "B", "C", "D", "A"};
            HashSet<string> h1 = new HashSet<string>(list);
            HashSet<string> h2 = new HashSet<string>(list);
            h2.Add("Adhi");
            h2.Add("Mahesh");
            h2.Add("Adhi");
            h2.Add("A");

            foreach (string s in h1)
                Console.Write(s+" ");
            Console.WriteLine();
            foreach (string s in h2)
                Console.Write(s+" ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------Union Method-------------");

            HashSet<string> h3 = h1.Union(h2).ToHashSet();

            foreach (string s in h3)
                Console.Write(s+" ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------UnionWith Method-------------");

            h1.UnionWith(h2);

            foreach (string s in h1)
                Console.Write(s+" ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------IntersectWith----------------");

            h1.IntersectWith(h2);

            foreach(string s in h1)
                Console.Write(s+" ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------ExceptWith-------------------");

            h2.ExceptWith(h1);

            foreach(String s in h1)
                Console.Write(s+" ");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("h1.IsProperSubsetOf(h2) : " + h1.IsProperSubsetOf(h2));
            Console.WriteLine("h2.IsProperSubsetOf(h1) : " + h2.IsProperSubsetOf(h1));
            Console.WriteLine("h1.IsProperSupersetOf(h2) : "+h1.IsProperSupersetOf(h2));
        }
    }
}
