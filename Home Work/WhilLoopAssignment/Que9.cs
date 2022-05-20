using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.WhilLoopAssignment
{
    internal class Que9
    {
        static void Main(string[] args)
        {
            //IMEI is valid or not
            Console.WriteLine("Enter a IMEI number");
            long a=Convert.ToInt64(Console.ReadLine());
            long sum = 0, etc = 0, sod = 0, n = 0 ,count=0,b=a;
            while(b>0)
            {
                count++;
                b = b / 10;
            }
            if (count == 15)
            {
                for (int i = 1; i <= 15; i++)
                {
                    etc = a % 10;
                    if (i % 2 == 0)
                    {
                        sod = etc + etc;
                        while (sod > 0)
                        {
                            n = sod % 10;
                            sum = sum + n;
                            sod = sod / 10;
                        }
                    }
                    else
                        sum = sum + etc;
                    a = a / 10;
                }
                Console.WriteLine(sum);
                if (sum % 10 == 0)
                    Console.WriteLine("Great, Your IMEI number is valid !");
                else
                    Console.WriteLine("IMEI is not valid.");
            }
            else
                Console.WriteLine("Invalid input or not a 15 numbers..");
        }
    }
}
