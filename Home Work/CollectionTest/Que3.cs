using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Home_Work.CollectionTest
{
    public class Player
    {
        int playerid;
        string name,country,team;
        public Player(int playerid,string name,string country,string team)
        {
                this.playerid = playerid;
                this.name = name;
                this.country = country;
                this.team = team;
            
        }
        public Player() { }
        
    }
    internal class Que3
    {
        static void Main(string[] args)
        {
            Player p=new Player();
            ArrayList a=new ArrayList();
            a.Add(new Player(1,"MS Dhoni","India", "Chennai Super Kings"));
            a.Add(new Player(2, "Pat Cummins", "Australia", "Kolkata Knight Riders"));
            a.Add(new Player(3, "Jhye Richardson", "Australia", "Punjab Kings"));
            a.Add(new Player(4, "Glenn Maxwell", "Australia", "Royal Challengers Bangalore"));
            a.Add(new Player(5, "David Warner", "Australia", "Sunrise hydrabad"));
            a.Add(new Player(6, "Marcus Stoinis", "Australia", "Delhi Capitals"));
            a.Add(new Player(7, "Nathan Coulter-Nile", "Australia", "Mumbai Indians"));
            a.Add(new Player(8, "Dan Christian", "Australia", "Royal Challengers Bangalore"));
            a.Add(new Player(9, "Kane Richardson", "Australia", "Royal Challengers Bangalore"));
            a.Add(new Player(10, "Adam Zampa", "Australia", "Royal Challengers Bangalore"));
            a.Add(new Player(11, "Daniel Sams", "Australia", "Royal Challengers Bangalore"));
            a.Add(new Player(12, "Jason Behrendorff", "Australia", "Chennai Super Kings"));
            a.Add(new Player(13, "Ben Cutting", "Australia", "Kolkata Knight Riders"));
            a.Add(new Player(14, "Samuel Billings", "England", "Kolkata Knight Riders"));
            a.Add(new Player(15, "Devon Conway", "New Zealand", "Chennai Super Kings"));

            
        }
    }
}
