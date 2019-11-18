using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Relic
{
    class Potion : Item
    {
        public int heal;

        public new string GetInfo()
        {
            return "Name: " + name + "\n Restore: " + heal;
        }

        public void Use(Hero target)
        {
            target.ModifyHp(heal);
            Console.WriteLine("");
        }
    }
}
