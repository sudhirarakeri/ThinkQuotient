using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Array1
{
    internal class _2DArrayMax
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 22, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };

            int max = int.MinValue;
            //int max = a[0, 0];
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if(max<a[i,j])
                        max = a[i,j];
                }
            }
            Console.WriteLine(max);
        }
    }
}
