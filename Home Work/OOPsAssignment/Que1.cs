using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.OOPsAssignment
{
    class Pen
    {
        string Brand, Color;
        int Price;
        public Pen()
        {
            Console.WriteLine("-------PEN-------");
        }
        public void SetBrand(string Brand)
        {
            this.Brand = Brand;
        }
        public string GetBrand()
        {
            return Brand;
        }
        public void SetColor(string Color)
        {
            this.Color = Color;
        }
        public string GetColor()
        {
            return Color;
        }
        public void SetPrice(int Price)
        {
            this.Price = Price;
        }
        public int GetPrice()
        {
            return Price;
        }
    }
    internal class Que1
    {
        static void Main(string[] args)
        {
            Pen p1=new Pen();
            Console.WriteLine("Enter Pen Brand =");
            p1.SetBrand(Console.ReadLine());
            Console.WriteLine("Enter Pen Color =");
            p1.SetColor(Console.ReadLine());
            Console.WriteLine("Enter Pen Price =");
            p1.SetPrice(Convert.ToInt32(Console.ReadLine()));
            int priz=p1.GetPrice();
            Console.WriteLine($"Pen Brand is {p1.GetBrand()} Color is {p1.GetColor()} Prize is "+priz);
            Console.WriteLine();

            Pen p2 = new Pen();
            Console.WriteLine("Enter Pen Brand =");
            p2.SetBrand(Console.ReadLine());
            Console.WriteLine("Enter Pen Color =");
            p2.SetColor(Console.ReadLine());
            Console.WriteLine("Enter Pen Price =");
            p2.SetPrice(Convert.ToInt32(Console.ReadLine()));
            string brend = p2.GetBrand();
            Console.WriteLine($"Pen Brand is {brend} Color is {p1.GetColor()} Prize is {p2.GetPrice()}");
        }
    }
}
