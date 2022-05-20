using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que11
    {
        static void Main(string[] args)
        {
            //descending order
            string[] n = { "sudhir", "amit", "rohit", "bhushan", "dinesh" };

            Array.Sort(n);
            for(int i=n.Length-1; i>=0; i--)
            {
                Console.WriteLine(n[i]);
            }
        }
    }
}
