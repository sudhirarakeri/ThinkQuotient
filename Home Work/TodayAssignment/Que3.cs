using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que3
    {
        static void Main(string[] args)
        {
            //given element present or not
            int[] arr = { 22, 33, 44, 55, 66, 12 };
            Console.WriteLine("Enter a no.");
            int a = Convert.ToInt32(Console.ReadLine());
            bool b = false;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                    b = true;
            }
            if(b==true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
