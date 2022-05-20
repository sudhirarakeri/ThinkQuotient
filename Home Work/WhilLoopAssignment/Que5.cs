using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.WhilLoopAssignment
{
    internal class Que5
    {
        static void Main(string[] args)
        {
            //red blue
            for(int i = 1; i <=100; i++)
            {
                if(i%3==0&&i%5==0)
                    Console.WriteLine("RedBlue");
                else if(i%3==0)
                    Console.WriteLine("Red");
                else
                    Console.WriteLine("Blue");
            }
        }
    }
}
