using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Pattern
{
    internal class Pattern6
    {
        static void Main(string[] args)
        {
            /*
            1
            AB
            1234    
            ABCDE
            1234
            AB
            1
             */
            int k = 1;
            for(int i = 1; i <=5; i++)
            {
                char c = 'A';
                if (i == 3)
                {
                    i++;
                    k++;
                }
                for(int j = 1; j <=i*2-i&&i<=4; j++)
                {
                    if (i % 2 == 0&&k==1)
                    {
                        Console.Write(c);
                        c++;
                    }
                    else
                    Console.Write(j);
                    
                }
                for(int j=1; j <=i*2-i&&i<=4; j++)
                {

                }
                k = 1;
                Console.WriteLine();
            }
        }
    }
}
