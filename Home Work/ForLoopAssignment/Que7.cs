using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que7
    {
        static void Main(string[] args)
        {
            //fibbnacci 
            int a = 0, b = 1,c=0;
            for(int i = 0; i < 10; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
