using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Relic
{
    class HealthPotion : Item
    {
        private new string name = "Health Potion";

        string description;

        int heal = 20;

        public new string GetInfo()
        {
            description = "Name: " + name + "\n Restore: " + heal + "\n Description: A bottle filled with a mysterious fluid found in the field of the fallen";
            return description;
        }
        public void Use(Hero target)
        {
            target.ModifyHp(heal);
            Console.WriteLine("");
        }
    }
}
