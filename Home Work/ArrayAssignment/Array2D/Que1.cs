using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment.Array2D
{
    internal class Que1
    {
        static void Main(string[] args)
        {
            //max per row and col
            int[,] a = { { 50, 60, 78, 87, 95 }, 
                         { 98, 87, 75, 76, 99 }, 
                         { 98, 99, 97, 95, 100 } };
            int max = int.MinValue;
            Console.WriteLine("Max in per Row");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if(max<a[i,j])
                        max = a[i,j];
                    if(j==a.GetLength(1)-1)
                        Console.Write(max+" ");
                }
                max = int.MinValue;
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Max in per Column");
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for(int j=0; j < a.GetLength(0); j++)
                {
                    if (max < a[j, i])
                        max = a[j, i];
                    if (j == a.GetLength(0) - 1)
                        Console.Write(max + " ");
                }
                max = int.MinValue;
            }
            Console.WriteLine();
        }
    }
}
