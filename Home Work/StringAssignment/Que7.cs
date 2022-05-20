using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.StringAssignment
{
    internal class Que7
    {
        static void Main(string[] args)
        {
            //takes character at position at index of that string
            string[] n = { "winter" , "fall" , "summer" , "spring" };
            string result = "";

            for(int i = 0; i < n.Length; i++)
            {
                string nl = n[i];
                for (int j = i; j < nl.Length; j++)
                {
                    result += nl[j];
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
