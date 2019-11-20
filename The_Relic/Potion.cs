using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Relic
{
    class Potion : Item
    {
        public int healthPoint;

        public int amount;

        public new string GetInfo()
        {
            return "Name: " + name + "\n Restore: " + healthPoint;
        }

        public void Use(Hero target)
        {
            while (amount >= 0)
            {
                target.ModifyHp(healthPoint);
                Console.WriteLine("You restored " + healthPoint + " health points");
            }

        }
    }
}
