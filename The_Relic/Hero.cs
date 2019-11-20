using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Relic
{
    class Hero : Character
    {
        public void UseItem(int n, Hero target)
        {
            inventory.UseItem(n, target);
        }

        public void Attack(Hero target)
        {
            
        }
    }
}
