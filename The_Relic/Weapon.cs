using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Relic
{
    class Weapon : Item
    {
        public new string GetInfo()
        {
            return name;
        }
        public new void Use(Character target)
        {

        }
    }
}
