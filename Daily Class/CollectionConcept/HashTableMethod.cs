using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Daily_Class.CollectionConcept
{
    class Stud
    {
        int id;
        string name;
        public Stud(int id,string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine(id+" "+name);
        }
        public override string ToString()
        {
            return " id is " + id + "name is " + name;
        }
    }
    internal class HashTableMethod
    {
        
        static void Main(string[] args)
        {
            ArrayList a1=new ArrayList() { "a","b","v"};
            ArrayList a2=new ArrayList() { "as","as","as"};

            Hashtable h1=new Hashtable();
            /*h1.Add("ram", 1);
            h1.Add("kit", a1);
            h1.Add("mit", a2);*/
            h1.Add(new Stud(1, "om"), 67);
            h1.Add(new Stud(1, "om"), 69);

            foreach(DictionaryEntry s in h1)
            {
                Console.WriteLine(s.Key+" "+s.Value);
            }
            /*foreach (var s in h1.Keys)
            {
                Console.Write(s + " " );
                if(h1[s] is ArrayList)
                {
                    ArrayList lst= (ArrayList)h1[s];
                    foreach (var i in lst)
                        Console.Write(i+" ");
                }
                else
                    Console.WriteLine(h1[s]);
                Console.WriteLine();
            }*/

        }
    }
}
