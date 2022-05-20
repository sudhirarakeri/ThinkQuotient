using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Array1
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] arr=new int[3][];
            arr[0] = new int[5];
            arr[1] = new int[2];
            arr[2] = new int[3];

            for(int i=0;i<arr.GetLength(0);i++)
            {
                Console.WriteLine($"enter {arr[i].Length} no. in {(i+1)}st row  ");
                for(int j=0;j<arr[i].Length; j++)
                {
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
