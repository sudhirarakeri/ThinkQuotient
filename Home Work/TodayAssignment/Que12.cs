using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que12
    {
        static void Main(string[] args)
        {
            //count char,num,special
            string n = "hi@01239azAZ";
            int c = 0, num = 0, s = 0;
            for(int i = 0; i < n.Length; i++)
            {
                if (char.IsLetter(n[i]))
                    c++;
                else if(char.IsDigit(n[i]))
                    num++;
                else
                    s++;
            }
            Console.WriteLine($"Total Character is {c} \nNumber is {num} \nSpecial charater {s}");
        }
    }
}
