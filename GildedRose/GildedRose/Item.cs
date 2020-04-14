using System;
using GildedRose;

namespace Katas
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public Item(string name, int sellIn, int quality)
        {
            Quality = quality;
            SellIn = sellIn;
            Name = name;
        }

        public bool IsSellinLessThanZero()
        {
            return SellIn < 0;
        }

        public bool IsQualityGreaterThanZero()
        {
            return Quality > 0;
        }

        public bool IsQualityLessThanFifty()
        {
            return Quality < 50;
        }

        public bool IsNotSulfuras()
        {
            return !"Sulfuras, Hand of Ragnaros".Equals(Name);
        }

        public bool IsNotBackstagePasses()
        {
            return !"Backstage passes to a TAFKAL80ETC concert".Equals(Name);
        }

        public bool IsNotAgedBrie()
        {
            return (!"Aged Brie".Equals(Name));
        }
    }
}