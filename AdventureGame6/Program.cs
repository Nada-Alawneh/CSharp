using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("===== ADVENTURE GAME =====\n");

                
                Warrior war = new Warrior("Alex", 80);
                Wizard wiz = new Wizard("Luna", 70);

                GameCharacter[] GC = { war, wiz };

                foreach (var character in GC)
                {
                    Console.WriteLine($"{character.Name} enters the game!");
                    character.UseSpecialAbility();
                    character.TakeDamage(10);
                    Console.WriteLine($"{character.Name}'s health: {character.Health}\n");
                }

                
                war.Heal();
                Console.WriteLine($"Alex health: {war.Health}\n");

                war.Heal(15);
                Console.WriteLine($"Alex health: {war.Health}\n");

                wiz.Heal();
                Console.WriteLine($"Luna health: {wiz.Health}\n");

                wiz.Heal(15);
                Console.WriteLine($"Luna health: {wiz.Health}\n");

                
                HealthPotion h = new HealthPotion();
                h.PotionName = "Health Potion";
                h.Collect();

                h.Use(wiz, "15");   // RIGHT
                h.Use(wiz, "abc");  // WRONG
            }
        }
    }
}
