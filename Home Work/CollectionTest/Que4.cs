using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Home_Work.CollectionTest
{
    internal class Que4
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "one");
            ht.Add(2,"two");
            ht.Add(3,"three");
            ht.Add(4,"four");
            ht.Add(5,"five");
            ht.Add(6,"six");
            ht.Add(7,"seven");
            ht.Add(8,"eigth");
            ht.Add(9,"nine");
            ht.Add(10,"ten");

            ArrayList arr = new ArrayList();
            foreach (var item in ht.Keys)
            {
                int n = Convert.ToInt32(item);
                if (n % 3 == 0)
                {
                    arr.Add(item);
                }
            }
            for (int i = 0; i < arr.Count; i++)
            {
                ht.Remove(arr[i]);
            }
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }

            
        }
    }
}
