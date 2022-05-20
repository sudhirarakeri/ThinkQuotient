using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment.ArrayTest1
{
    abstract class a
    {
        //abstract void k();
    }
    interface b
    {
        abstract void k();
    }
    internal class Que4
    {
        static void Main(string[] args)
        {
            //frequency Count
            int[] a = { 1, 3, 2, 1, 4, 2, 1, 3 };
            int c = 0;
            for(int i = 0; i < a.Length; i++)
            {
                for(int j=0;j<a.Length; j++)
                {
                    if (a[i] == a[j] && i > j)
                        break;
                    if (a[i] == a[j])
                        c++;
                }
                if(c!=0)
                   Console.WriteLine($"Frenquency of {a[i]} is "+c);
                c = 0;
            }
        }
    }
}
