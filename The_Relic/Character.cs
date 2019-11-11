using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Relic
{
    class Character
    {
        protected string name;

        protected Inventory inventory;

        protected int hp;

        protected int mp;

        protected int strenght;

        public void AddToInventory(Item item)
        {

        }
        public void RemoveFromInventory(int n)
        {

        }
        public void UseItem(int n, Character target)
        {

        }
        public void UseItem(int n)
        {

        }
        public int GetInventoryLenght()
        {

        }
        public string GetItemInfo(int n)
        {

        }
        public int GetHp()
        {

        }
        public int ModifyHp(int amount)
        {

            hp += amount;

            return hp;

        }
        public void Attack(Character target)
        {

        }
    }
}
