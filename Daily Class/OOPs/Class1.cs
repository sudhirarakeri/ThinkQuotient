using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.OOPs
{
    class Book
    {
        public string? name,author;
        public int price;
        public static string traine;
        public void Display()
        {
            Console.WriteLine("Enter name,author,price");
            name =Console.ReadLine();
            author = Console.ReadLine();
            price = Convert.ToInt32(Console.ReadLine());
            traine = Console.ReadLine();
            Console.WriteLine(name+" + "+author+" + "+price+" ");
            Console.WriteLine();
        }
        /*
         * static void Main(string[] args)
        {
            name=Console.ReadLine();
            author = Console.ReadLine();
            price = Convert.ToInt32(Console.ReadLine());
        }*/
    }
    internal class BookTest
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.Display();
            b.name = "Ramayan";
            b.author = "Valmiki";
            b.price = 150;

            Console.WriteLine($"Book Name is {b.name} Book Author is {b.author} Price is {b.price}");
            
        }
    }
}
