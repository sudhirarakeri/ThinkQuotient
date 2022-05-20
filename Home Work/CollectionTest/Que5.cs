using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Home_Work.CollectionTest
{
    internal class Que5
    {
        static void Main(string[] args)
        {
            Hashtable ht=new Hashtable();
            ht.Add("a", 1);
            ht.Add("b", 2);
            ht.Add("c", 3);
            ht.Add("d", 4);
            ht.Add("e", 5);
            Console.WriteLine("give specified key");
            string n=Console.ReadLine();
            foreach(DictionaryEntry e in ht)
            {
                string k=e.Key.ToString();
                if (k == n)
                {
                    Console.WriteLine(e.Value);
                }
            }
        }
    }
}
