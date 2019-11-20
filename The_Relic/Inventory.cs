using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Relic
{
    class Inventory
    {
        private List<Item> items = new List<Item>();

        public void Add(Item item)
        {
            items.Add(item);
        }

        public void Remove(int n)
        {
            items.RemoveAt(n);
        }

        public string GetItemInfo(int n)
        {
            string ItemInfo = items[n].GetInfo();

            return ItemInfo;
        }

        public void UseItem(int n, Character c)
        {
            items[n].Use(c);
        }

        public int GetLenght()
        {
            int lenght = items.Count;

            return lenght;
        }
    }
}
