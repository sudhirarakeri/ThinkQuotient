using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Home_Work.CollectionTest
{
    internal class Que6
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("Nasik");
            al.Add("pune");

            Hashtable ht = new Hashtable();
            for(int i = 0; i < al.Count; i++)
            {
                int c = 0;
                for (int j = 0; j < al.Count; j++)
                {
                    if (al[i] == al[j] && j < i)
                        break;
                    else if (al[i] == al[j])
                        c++;
                }
                if(c>0)
                    ht.Add(al[i], c);
            }

            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }
        }
    }
}
