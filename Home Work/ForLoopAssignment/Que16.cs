using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que16
    {
        static void Main(string[] args)
        {
            //prime no. bt 400 to 300
            for(int i = 400; i >=300; i--)
            {
                int count = 0;
                for(int j=1;j<=i;j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if(count==2)
                    Console.WriteLine(i);
            }
        }
    }
}
