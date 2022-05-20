using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que9
    {
        static void Main(string[] args)
        {
            // 0 3 8 15
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(i * i - 1);
            }
        }
    }
}
