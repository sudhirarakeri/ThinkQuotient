using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que4
    {
        static void Main(string[] args)
        {
            //Longest word in string
            string n = "even this is previous very than one";
            string[] s =n.Split(" ");
            int c = s[0].Length;
            for(int i = 0; i < s.Length; i++)
            {
                if (c < s[i].Length)
                    c= s[i].Length;
            }
            for(int i = 0; i < s.Length; i++)
            {
                if(c==s[i].Length)
                    Console.WriteLine(s[i]);
            }
            
        }
    }
}
