using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame6
{
    internal class Warrior : GameCharacter //inherit from abstract class
    {
        public Warrior(string name, int health) : base(name, health)
        {
        }

        public override void UseSpecialAbility()//abstract method so the imp only for this class 
        {
            Console.WriteLine("The Warrior attacks with a sword!");
        }

        public override void TakeDamage(int amount)//poly :overriding method because same name & same parameter but the imp different 
        {
            Health -= (amount - 2);

        }
    }
}
