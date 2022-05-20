using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Daily_Class.CollectionConcept
{
    internal class DictionaryMethod
    {
        static void Main(string[] args)
        {
            //we can give particular data type in dictionary
            //Dictionary<string,Object> d=new Dictionary<string,Object>();
            Dictionary<string,int> d=new Dictionary<string,int>();
            d.Add("aa", 20);
            d.Add("bb", 10);
            d.Add("cc", 40);

            foreach(KeyValuePair<string,int> kvp in d)
                Console.WriteLine(kvp.Key+" "+kvp.Value);
        }
    }
}
