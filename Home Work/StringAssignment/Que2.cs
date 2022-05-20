using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.StringAssignment
{
    internal class Que2
    {
        static void Main(string[] args)
        {
            //check if two strings are anagrams 
            string n1 = "keep";
            string n2 = "peak";
            char[] c1=n1.ToCharArray();
            char[] c2=n2.ToCharArray();
            Array.Sort(c1);
            Array.Sort(c2);
            bool s = true;
            if (c1.Length != c2.Length)
                s = false;
            else
            {
                for (int i = 0; i < c1.Length; i++)
                {
                    if (c1[i] != c2[i])
                    {
                        s = false;
                        break;
                    }
                }
            }
            if(s==true)
                Console.WriteLine("angrams");
            else
                Console.WriteLine("not angrams");
        }
    }
}
