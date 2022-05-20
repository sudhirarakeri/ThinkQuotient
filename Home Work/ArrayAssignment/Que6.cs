using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ArrayAssignment
{
    internal class Que6
    {
        static void Main(string[] args)
        {
            //insert an element a specific position
            int[] arr = new int[20];
            Console.WriteLine("Enter a Size");
            int size=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Enter a Position ");
            int pos=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value");
            int value=Convert.ToInt32(Console.ReadLine());
            if(pos==size)
            {
                arr[size] = value;
                size++;
            }
            else if(pos>0&&pos<size)
            {
                for(int i=size-1; i>=pos; i--)
                {
                    arr[i + 1] = arr[i];
                }
                arr[pos] = value;
            }
            else
                Console.WriteLine("Index Out Of Range");
            for (int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
