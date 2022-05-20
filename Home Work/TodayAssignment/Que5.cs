using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que5
    {
        static void Main(string[] args)
        {
            //count vowel
            string n = "hi are you there or not";
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int c = 0;
            for(int i = 0; i < vowels.Length; i++)
            {
                for(int j = 0; j < n.Length; j++)
                {
                    if (vowels[i] == n[j] && j < i)
                        break;
                    if (vowels[i] == n[j])
                        c++;
                }
                if(c!=0)
                    Console.WriteLine($"Total {vowels[i]} is {c}");
                c = 0;
            }
        }
    }
}
