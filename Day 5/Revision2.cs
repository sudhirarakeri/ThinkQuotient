using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set ; }
        public double Salary { get ; set; }
    }
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
    internal class Revision2
    {
        static void Main(string[] args)
        {
            Product[] pl = new Product[]
            {
                new Product{ProductId=101,ProductName="Cipla"},
                new Product{ProductId=102,ProductName="Wipro"},
                new Product{ProductId=103,ProductName="Bajaj"},
                new Product{ProductId=104,ProductName="Tata"},
                new Product{ProductId=105,ProductName="Serum"},
            };

            foreach(Product p in pl)
                Console.WriteLine($"Product ID : {p.ProductId} Product Name : {p.ProductName}");

            /*Employee[] emp = new Employee[]
            {
                 new Employee{Id=1,Name= "ravi",Salary= 13000},
                 new Employee{Id=2,Name= "june",Salary= 13000},
                 new Employee{Id=3,Name= "ken",Salary= 13000},
                 new Employee{Id=4,Name= "paxthon",Salary= 13000},
                 new Employee{Id=5,Name= "devi",Salary= 13000},
            };
           

            foreach(Employee e in emp)
                Console.WriteLine(e.Id+" "+e.Name+" "+e.Salary);*/
        }
    }
    class TwoDArray
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 }, { 6, 7, 8 } };


            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j=0;j<arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[3] {1,2,3};
            arr[1] = new int[2] {1,2};
            arr[2] = new int[4] {1,2,3,4};    

            for(int i=0;i<arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr[i].Length;j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
    class DictonaryQues
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(91, "India");
            dic.Add(63, "Austrilia");
            dic.Add(10, "America");

            Console.WriteLine("Country Code  |  Country Name");
            foreach (KeyValuePair<int, string> pair in dic)
            {
                Console.WriteLine("    "+pair.Key+"        |    "+pair.Value);
            }
        }
    }
    class Test<T>
    {
        T element;

        public void Add(T element)
        {
            this.element = element;
        }
        public T Display()
        {
            return element;
        }
    }
    class AcceptAlldataByOwnGenericMethod
    {
        static void Main(string[] args)
        {
            Test<int> t1 = new Test<int>();
            t1.Add(1);

            Test<string> t2 = new Test<string>();
            t2.Add("sudhir");
        }
    }

    

    class DelegateConcept
    {
        public delegate void multidelegate(string n);

        public static void Upper(string n)
        {
            Console.WriteLine("Upper case : "+n.ToUpper());
        }
        public static void Lower(string n)
        {
            Console.WriteLine("Lower case : "+n.ToLower());
        }

        static void Main(string[] args)
        {
            string n = "Sudhir";
            multidelegate u = Upper;
            u += Lower;
            u(n);
        }
    }
}
