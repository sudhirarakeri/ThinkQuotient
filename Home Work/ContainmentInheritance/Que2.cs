using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ContainmentInheritance
{
    class Pen
    {
        Refill r=new Refill();
        int capLength;
        string brand;

        public int CapLength { get => capLength; set => capLength = value; }
        public string Brand { get => brand; set => brand = value; }
        internal Refill R { get => r; set => r = value; }
    }
    class Refill
    {
        string inkColor;
        float length;
        Nib n=new Nib();

        public string InkColor { get => inkColor; set => inkColor = value; }
        public float Length { get => length; set => length = value; }
        internal Nib N { get => n; set => n = value; }
    }
    class Nib
    {
        string materialType;
        float width;

        public string MaterialType { get => materialType; set => materialType = value; }
        public float Width { get => width; set => width = value; }
    }
    internal class Que2
    {
        static void Main(string[] args)
        {
            Pen p = new Pen();
            Console.WriteLine("Brand");
            p.Brand =Console.ReadLine();
            Console.WriteLine("Cap Length");
            p.CapLength=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Length");
            p.R.Length = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ink Color");
            p.R.InkColor= Console.ReadLine();
            Console.WriteLine("Material Type");
            p.R.N.MaterialType=Console.ReadLine();
            Console.WriteLine("Width");
            p.R.N.Width= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Brand is "+p.Brand);
            Console.WriteLine("Cap Length is " + p.CapLength);
            Console.WriteLine("Length is " + p.R.Length);
            Console.WriteLine("Ink Color is " + p.R.InkColor);
            Console.WriteLine("Material Type is " + p.R.N.MaterialType);
            Console.WriteLine("Width is " + p.R.N.Width);
        }
    }
}
