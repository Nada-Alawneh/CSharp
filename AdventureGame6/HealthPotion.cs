using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame6
{
    internal class HealthPotion : ICollectible
    {
        public string PotionName { get; set; }

        public void Collect()
        {
            Console.WriteLine("You have collected a health potion!");
        }



        public void Use(GameCharacter character, string amountText)
        {
            try
            {
                int amount = int.Parse(amountText);

                character.Heal(amount);

                Console.WriteLine($"You have used a health potion and healed {amount} health points!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid amount. Please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The amount is too large or too small.");
            }
        }

    }
}
