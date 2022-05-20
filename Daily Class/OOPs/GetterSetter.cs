using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.OOPs
{
    class Movie
    {
        string MovieName,Director,Producer,MaleActor,FemaleActor;
        int Rating;

        public void SetMovieName(string MovNam)
        {
            MovieName = MovNam;
        }
        public string GetMovieName()
        {
            return MovieName;
        }
        public void SetDirector(string Direc)
        {
            Director = Direc;   
        }
        public string GetDirector()
        {
            return Director;
        }
        public void SetProducer(string Produ)
        {
            Producer= Produ;
        }
        public string GetProducer()
        {
            return Producer;
        }
        public void SetMaleActor(string MalAct)
        {
            MaleActor = MalAct;
        }
        public string GetMaleActor()
        {
            return MaleActor;
        }
        public void SetFemaleActor(string FemAct)
        {
            FemaleActor = FemAct;
        }
        public string GetFemaleActor()
        {
            return FemaleActor;
        }
        public void SetRating(int Rate)
        {
            Rating = Rate;
        }
        public int GetRating()
        {
            return Rating;
        }
    }
    internal class GetterSetterMovie
    {
        static void Main(string[] args)
        {
            Movie m = new Movie();
            Console.WriteLine("Enter movie name = ");
            m.SetMovieName(Console.ReadLine());
            m.SetDirector("Prashnath");
            m.SetProducer("Vijay");
            m.SetMaleActor("Yash");
            m.SetFemaleActor("Srinidhi");
            m.SetRating(5);

            string mn=m.GetMovieName();
            Console.WriteLine("Movie Name is "+mn);
            Console.WriteLine($"Movie Director is {m.GetDirector()}");
            string mp=m.GetProducer();
            Console.WriteLine("Movie Producer is "+mp);
            Console.WriteLine("Male Actor is "+m.GetMaleActor());
            string fa=m.GetFemaleActor();
            Console.WriteLine("Female Actor is "+fa);
            int r = m.GetRating();
            Console.WriteLine("Rating is "+r);
        }
    }
}
