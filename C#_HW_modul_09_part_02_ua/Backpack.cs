using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW_modul_09_part_02_ua
{
    internal class Backpack
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Material { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }

        private double currentVolume = 0;
        public List<Item> Contents { get; private set; } = new List<Item>();

        public delegate void ItemAddedEventHandler(object sender, ItemEventArgs e);
        public event ItemAddedEventHandler ItemAdded;

        public void AddItem(Item item)
        {
            if (currentVolume + item.Volume > Volume)
            {
                throw new InvalidOperationException("Cannot add item, volume exceeded.");
            }

            Contents.Add(item);
            currentVolume += item.Volume;
            ItemAdded?.Invoke(this, new ItemEventArgs { Item = item });
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public double Volume { get; set; }
    }

    public class ItemEventArgs : EventArgs
    {
        public Item Item { get; set; }
    }
}
