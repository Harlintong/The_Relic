using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Relic
{
    class Item
    {
        public string name;

        protected string description;

        public string GetInfo()
        {
            return description;
        }
        public void Use(Character target)
        {

        }
    }
}
