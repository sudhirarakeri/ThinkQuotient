using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Array1
{
    internal class _2DArray
    {
        static void Main(string[] args)
        {
            int[,] b = new int[3,2];
            Console.WriteLine("Total Length " + b.Length);
            Console.WriteLine("Row Length " + b.GetLength(0));
            Console.WriteLine("Col Length " + b.GetLength(1));

            for(int i = 0; i < b.GetLength(0); i++)
            {
                Console.WriteLine("Enter a Number");
                for(int j = 0; j < b.GetLength(1); j++)
                {
                    b[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for(int i = 0; i < b.GetLength(0); i++)
            {
                for(int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
