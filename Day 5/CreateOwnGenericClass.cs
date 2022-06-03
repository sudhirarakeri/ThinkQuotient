using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    public class Test1<TYPE> // < > means Placeholder for datatype
    {
        TYPE element;

        public void Add(TYPE element) => this.element = element;
        public TYPE Display()
        { return this.element; }

    }
    public class Test2<T1,T2>
    {
        T1 element1;
        T2 element2;

        public void Add(T1 element1, T2 element2)
        {
            this.element1 = element1;
            this.element2 = element2;
        }

        /*public T1 Display()
        {
            return $"{this.element1}";
        }*/
    }
    class Dept
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Id} : {Name}";
        }
    }
    internal class CreateOwnGenericClass
    {
        static void Main(string[] args)
        {
            Test1<int> t1 = new Test1<int>();
            t1.Add(1);
            Console.WriteLine(t1.Display());

            Test1<string> t2 = new Test1<string>();
            t2.Add("Rajesh");
            Console.WriteLine(t2.Display());

            Test1<Dept> t3 = new Test1<Dept>();
            t3.Add(new Dept { Id = 1, Name = "Computer" });
            Console.WriteLine(t3.Display());
        }
    }
}
