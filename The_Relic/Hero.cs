using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Relic
{
    class Hero : Character
    {
        public new string name;

        new int hp = 200;

        new int mp = 100;

        new int strenght = 20;

        int exp = 0;

        int level = 1;
    }
}
