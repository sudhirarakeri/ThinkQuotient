using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Pattern
{
    internal class Pattern1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No. of Rows");
            int r=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter No. of Columns");
            int c=Convert.ToInt32(Console.ReadLine());

            for(int row=1; row <= r; row++)
            {
                for(int col=1; col <= c; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
