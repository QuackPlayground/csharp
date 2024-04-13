using funproj;
using System;


namespace FunProj
{
    public class Program
    {
        static void Main(string[] args)
        {
            Warrior thor = new Warrior("Thor", 100, 26, 10); // health, damage, how much he can block
            MagicWarrior loki = new MagicWarrior("Loki", 75, 20, 10, 50); 
            
            Battle.StartFight(thor, loki);
        }
    }
}