using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que10
    {
        static void Main(string[] args)
        {
            //two string angram or not
            string n1 = "rrhha";
            string n2 = "hhrra";

            char[] c1 = n1.ToCharArray();
            char[] c2 = n2.ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            string new1=new string(c1);
            string new2=new string(c2);

            if(new1.CompareTo(new2)==0)
                Console.WriteLine("angram");
            else
                Console.WriteLine("not angram");

            /*bool b = true;
            if (c1.Length != c2.Length)
                b = false;
            else
            {
                for(int i = 0; i < c1.Length; i++)
                {
                    for(int j= i; j < c2.Length; j++)
                    {
                        if (c1[i] != c2[j])
                        {
                            b = false;
                            break;
                        }
                        else
                            break;
                    }
                }
            }
            if(b==true)
                Console.WriteLine("Angrams");
            else
                Console.WriteLine("Not angrams");*/
        }
    }
}
