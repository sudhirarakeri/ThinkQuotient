using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Array1
{
    internal class ForEach
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 4, 7, 3, 1, 3, 2, 5 };

            System.Array.Sort(a); 
            foreach(int i in a)
                Console.WriteLine(i);
        }
    }
}
