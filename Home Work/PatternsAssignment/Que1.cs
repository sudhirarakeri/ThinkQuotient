using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.PatternsAssignment
{
    internal class Que1
    {
        static void Main(string[] args)
        {
            //Pattern #@#@#
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    if(j%2!=0)
                        Console.Write("#");
                    else
                        Console.Write("@");
                }
                Console.WriteLine();
            }
        }
    }
}
