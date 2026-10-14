using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame6
{
    public abstract class GameCharacter
    {
        private string _name;

        private int _health;

        public string Name { get; set; } //encapsulation because we hiding the data 

        public int Health
        {
            get { return _health; }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    _health = value;
                }
                else
                {
                    Console.WriteLine("Health must be between 0 and 100.");
                }
            }
        }

        public GameCharacter(string name, int health)
        {
            _name = name;
            _health = health;
        }

        public abstract void UseSpecialAbility(); //abstract method

        public virtual void TakeDamage(int amount) //poly :overriding: same method & same parameter but different imp
        {
            Health -= amount;
        }

        public void Heal() //poly :overloading without parameter
        {
            Health += 10;
        }

        public void Heal(int amount)//poly :overloading with one parameter
        {
            Health += amount;
        }

    }
}
