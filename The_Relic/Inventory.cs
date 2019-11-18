using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Relic
{
    class Inventory
    {
        private List<Item> items;

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

        }
        public void UseItem(int n, Character c)
        {

        }
        public int GetLenght()
        {
        }
    }
}
