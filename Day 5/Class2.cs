using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Emp
    {
        int id;
        string name;
        long salary;

        public Emp(int id,string name,long salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public long Salary { get => salary; set => salary = value; }
    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            Emp[] e = new Emp[3] {new Emp(1,"s",45000), 
                                  new Emp(2, "t", 30000),
                                  new Emp(3, "g", 67000) };

            
            for(int i = 0; i < e.Length; i++)
            {
                if(e[i].Salary>=40000)
                {
                    Console.WriteLine($"Employee name is {e[i].Name}");
                    Console.WriteLine($"Salary is {e[i].Salary}");
                    Console.WriteLine();
                }
                
            }
        }
    }
}
