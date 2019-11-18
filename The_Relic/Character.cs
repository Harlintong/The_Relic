using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Relic
{
    class Character
    {
        public string name;

        protected Inventory inventory;

        public int hp;

        public int mp;

        public int strenght;

        public void AddToInventory(Item item)
        {
            inventory.Add(item);
        }
        public void RemoveFromInventory(int n)
        {
            inventory.Remove(n);
        }
        public void UseItem(int n, Character target)
        {
            inventory.UseItem(n, target);
        }
        public void UseItem(int n)
        {
            inventory.UseItem(n);
        }
        public int GetInventoryLenght()
        {
            return inventory.GetLenght();
        }
        public string GetItemInfo(int n)
        {
            return inventory.GetItemInfo(n);
        }
        public int GetHp()
        {
            return hp;
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
