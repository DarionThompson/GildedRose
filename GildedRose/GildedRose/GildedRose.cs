using System;
using System.Collections.Generic;

namespace Katas
{
	public class GildedRose
	{
		private static IList<Item> _items = null;

        public GildedRose(List<Item> items)
        {
			_items = items;
        }

		public void updateQuality()
		{
			for (int i = 0; i < _items.Count; i++)
            {
                if (IsNotAgedBrie(i) && IsNotBackstagePasses(i))
                {
                    if (_items[i].Quality > 0)
                    {
                        if (IsNotSulfuras(i))
                        {
                            _items[i].Quality = _items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (_items[i].Quality < 50)
                    {
                        _items[i].Quality = _items[i].Quality + 1;

                        if (!IsNotBackstagePasses(i))
                        {
                            if (_items[i].SellIn < 11)
                            {
                                if (_items[i].Quality < 50)
                                {
                                    _items[i].Quality = (_items[i].Quality + 1);
                                }
                            }

                            if (_items[i].SellIn < 6)
                            {
                                if (_items[i].Quality < 50)
                                {
                                    _items[i].Quality = (_items[i].Quality + 1);
                                }
                            }
                        }
                    }
                }

                if (IsNotSulfuras(i))
                {
                    _items[i].SellIn = (_items[i].SellIn - 1);
                }

                if (_items[i].SellIn < 0)
                {
                    if (IsNotAgedBrie(i))
                    {
                        if (IsNotBackstagePasses(i))
                        {
                            if (_items[i].Quality > 0)
                            {
                                if (IsNotSulfuras(i))
                                {
                                    _items[i].Quality = (_items[i].Quality - 1);
                                }
                            }
                        }
                        else
                        {
                            _items[i].Quality = (_items[i].Quality - _items[i].Quality);
                        }
                    }
                    else
                    {
                        if (_items[i].Quality < 50)
                        {
                            _items[i].Quality = (_items[i].Quality + 1);
                        }
                    }
                }
            }
        }

        private static bool IsNotSulfuras(int i)
        {
            return !"Sulfuras, Hand of Ragnaros".Equals(_items[i].Name);
        }

        private static bool IsNotBackstagePasses(int i)
        {
            return !"Backstage passes to a TAFKAL80ETC concert".Equals(_items[i].Name);
        }

        private static bool IsNotAgedBrie(int i)
        {
            return (!"Aged Brie".Equals(_items[i].Name));
        }
    }
}
