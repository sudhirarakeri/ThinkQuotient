using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class CreateOwnGenericMethod
    {
        /*static void Swap<T>(T a,T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($" a = {a} b = {b}");
        }*/
        static void Swap<T>(ref T a,ref T b)//call by refernce
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
            
        }
        static void Calculation(int a,int b,out int sum,out int multiply,out int div)
        {
            sum = a + b;
            multiply = a * b;
            div = a / b;
        }
        static void Main(string[] args)
        {
            int a = 10, b = 20, sum, multiply,div;
            Swap<int>(ref a,ref b);
            Console.WriteLine($"a = {a} b = {b}");
           
            Calculation(a,b,out sum,out multiply,out div);
            Console.WriteLine($"\nAdd = {sum} Multiply = {multiply} Division = {div}");

            /*Swap<int>(10, 20);
            Swap<string>("Hi", "Bye");
            Swap<double>(1.5, 5.1);*/
        }
    }
}
