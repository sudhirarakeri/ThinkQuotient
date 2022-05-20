using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.OOPs
{
    class Overload
    {
        public static void Pattern(int r)
        {
            for(int i = 0; i < r; i++)
            {
                for(int j=0; j < r; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Pattern(int r,int c,char ch)
        {
            for(int i=0;i<r;i++)
            {
                for(int j=0;j<c;j++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
        }
    }
    internal class OverEg1
    {
        static void Main(string[] args)
        {
            Overload.Pattern(5);
            Overload.Pattern(4,8,'$');
        }
    }
}
