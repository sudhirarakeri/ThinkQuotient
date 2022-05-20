using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment.Array2D
{
    internal class Que2
    {
        static void Main(string[] args)
        {
            //diagonal
            int[,] a = { { 1, 2, 3 },
                         { 4, 5, 6 },
                         { 7, 8, 9 }};
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = i; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                    break;
                }
            }
            Console.WriteLine();
            int k = 1;
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j=a.GetLength(1)-k;j>=0; j--)
                {
                    Console.Write(a[i, j]+" ");
                    break;
                }
                k++;
            }
        }
    }
}
