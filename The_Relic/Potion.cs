using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Relic
{
    class Potion : Item
    {
        private int heal = 20;

        public void Use(Hero target)
        {
            target.ModifyHp(heal);
            Console.WriteLine("");
        }
    }
}
