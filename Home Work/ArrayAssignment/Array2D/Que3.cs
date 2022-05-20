using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment.Array2D
{
    internal class Que3
    {
        static void Main(string[] args)
        {
            //transform
            int[,] a = { { 1, 2, 3, 4, 5 },
                         { 6, 7, 8, 9, 10 } };
            int[,] b = new int[5, 2];

            for(int i = 0; i < b.GetLength(1); i++)
            {
                for(int j = 0; j < b.GetLength(0); j++)
                {
                    b[j,i]=a[i,j];
                }
            }
            for(int i = 0; i < b.GetLength(0); i++)
            {
                for(int j=0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
