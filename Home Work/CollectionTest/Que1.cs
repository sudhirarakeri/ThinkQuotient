using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Home_Work.CollectionTest
{
    internal class Que1
    {
        static void Main(string[] args)
        {
            //Write a code to remove duplicate elements from above list. 
            ArrayList al =new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");

            for(int i=0;i<al.Count;i++)
            {
                int c = 0;
                for(int j=0;j<al.Count;j++)
                {
                    if(al[i].Equals(al[j])&&c==1)
                        al.RemoveAt(j);
                    else if (al[j] == al[i])
                        c++;
                }
            }
            foreach(var a in al)
                Console.WriteLine(a);

        }
    }
}
