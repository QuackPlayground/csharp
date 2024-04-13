using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funproj
{
    class Battle
    {
        // StartFight
        // warrior1 attacks warrior2, warrior2 is damaged and health decreased
        // Get attack result
        // warrior2 attacks warrior1, warrior1 is damaged and health decreased
        // Get attack result

        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while(true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over!!");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over!!");
                    break;
                }

            }
        }


        // Get Attack Result
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warAAttackAmount = warriorA.Attack();
            double warBBlockAmount = warriorB.Block();

            double dmgToWarB = warAAttackAmount - warBBlockAmount;

            if (dmgToWarB > 0)
            {
                warriorB.Health = warriorB.Health - dmgToWarB;
            } else
            {
                dmgToWarB = 0;
            }

            Console.WriteLine("{0} Attack {1} and deals {2} Damage", warriorA.Name, warriorB.Name, dmgToWarB);
            Console.WriteLine("{0} has {1} Health\n", warriorB.Name, warriorB.Health);

            if(warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is Victorious\n", warriorB.Name, warriorA.Name);

                return "Game Over";
            } else
            {
                return "Fight Again";
            }
        }

    }
}
