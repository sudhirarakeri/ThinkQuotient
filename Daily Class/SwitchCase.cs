using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class
{
    internal class SwitchCase
    {
        static void Main(string[] args)
        {
            //Switch Case
            /*
             In other language float in switch case not accepted.
             only in C# it's allowed.
             */
            Console.WriteLine("Enter a character =");
            char c = Convert.ToChar(Console.Read());

            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowels");
                    break;
                default:
                    Console.WriteLine("Consonent");
                    break;
            }

            Console.WriteLine("Enter a float number=");
            float f = Convert.ToSingle(Console.Read());

            switch (f) {
                case 0.4f: Console.WriteLine("greter");
                    break ;
                case 0.1f: Console.WriteLine("lesser");
                    break;
                default: Console.WriteLine("Invalid input");
                    break;
            }

            Console.WriteLine("standard name");
            string? sn=Console.ReadLine();

            switch (sn)
            {
                case "10": Console.WriteLine("enter a class A or B =");
                           char cn=Convert.ToChar(Console.Read());
                    switch (cn)
                    {
                        case 'A': Console.WriteLine("present A");
                            break;
                        case 'B': Console.WriteLine("Present B");
                            break;
                    }
                break;
            }
        }
    }
}
