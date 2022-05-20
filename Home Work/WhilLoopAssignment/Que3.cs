using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.WhilLoopAssignment
{
    internal class Que3
    {
        static void Main(string[] args)
        {
            //print even and if odd then square
            for(int i = 1; i <= 50; i++)
            {
                if(i%2==0)
                    Console.WriteLine(i);
                else
                    Console.WriteLine(i*i);
            }
        }
    }
}
