using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.OOPsAssignment
{
    class Stock
    {
        float Opening_Price, Closing_Price;
        String Stock_Name;

        public Stock()
        {
            Console.WriteLine("------Stock Markting------");
        }
        public void SetStockName(string Stock_Name)
        {
            this.Stock_Name = Stock_Name;
        }
        public string GetStockName()
        {
            return Stock_Name;
        }
        public void SetOpeningPrice(float op)
        {
            Opening_Price = op;
        }
        public float GetOpeningPrice()
        {
            return Opening_Price;
        }
        public void SetClosingPrice(float cp)
        {
            Closing_Price = cp;
        }
        public float GetClosingPrice()
        {
            return Closing_Price;
        }
    }
    internal class Que2
    {
        static void Main(string[] args)
        {
            Stock s1=new Stock();
            Console.WriteLine("Enter Stock Name =");
            s1.SetStockName(Console.ReadLine());
            Console.WriteLine("Enter Opening Price =");
            s1.SetOpeningPrice(Convert.ToSingle(Console.ReadLine()));
            Console.WriteLine("Enter Closing Price =");
            s1.SetClosingPrice(Convert.ToSingle(Console.ReadLine()));
            float cp = s1.GetClosingPrice();
            Console.WriteLine($"Stock Name is {s1.GetStockName()} Opening Price is {s1.GetOpeningPrice()} Closing Price is " + cp);
            Console.WriteLine();

            Stock s2 = new Stock();
            Console.WriteLine("Enter Stock Name =");
            s2.SetStockName(Console.ReadLine());
            Console.WriteLine("Enter Opening Price =");
            s2.SetOpeningPrice(Convert.ToSingle(Console.ReadLine()));
            Console.WriteLine("Enter Closing Price =");
            s2.SetClosingPrice(Convert.ToSingle(Console.ReadLine()));
            float cp1 = s2.GetClosingPrice();
            Console.WriteLine($"Stock Name is {s2.GetStockName()} Opening Price is {s2.GetOpeningPrice()} Closing Price is " + cp1);
            Console.WriteLine();
        }
    }
}
