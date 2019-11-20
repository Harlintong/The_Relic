using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Relic
{
    class Weapon : Item
    {
        public int strenght;

        public new string GetInfo()
        {
            return "Name: " + name + "\n Strenght: " + strenght;
        }

        public void Use(Hero target)
        {
            strenght += target.strenght;
        }
    }
}
