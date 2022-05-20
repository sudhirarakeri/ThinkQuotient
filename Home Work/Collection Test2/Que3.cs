using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.Collection_Test2
{
    internal class Que3
    {
        static void Main(string[] args)
        {
            HashSet<string> set1 = new HashSet<string>() { "a","b","c","d"};
            HashSet<string> set2 = new HashSet<string>() { "a","b","c","d"};

            set1.UnionWith(set2);
            foreach(string s in set1)
                Console.WriteLine(s);
        }
    }
}
