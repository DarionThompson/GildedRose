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

        public void UpdateQuality(List<Item> items)
        {
            foreach (var item in items)
            {
                UpdateItemQuality(item);
            }
        }

		public void UpdateItemQuality(Item item)
		{
            if (item.IsNotAgedBrie() && item.IsNotBackstagePasses())
            {
                if (item.IsQualityGreaterThanZero())
                {
                    if (item.IsNotSulfuras())
                    {
                        item.Quality = item.Quality - 1;
                    }
                }
            }
            else
            {
                if (item.IsQualityLessThanFifty())
                {
                    item.Quality = item.Quality + 1;

                    if (!item.IsNotBackstagePasses())
                    {
                        if (item.SellIn < 11)
                        {
                            if (item.IsQualityLessThanFifty())
                            {
                                item.Quality = (item.Quality + 1);
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.IsQualityLessThanFifty())
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }
                    }
                }
            }

            if (item.IsNotSulfuras())
            {
                item.SellIn = (item.SellIn - 1);
            }

            if (item.IsSellinLessThanZero())
            {
                if (item.IsNotAgedBrie())
                {
                    if (item.IsNotBackstagePasses())
                    {
                        if (item.IsQualityGreaterThanZero())
                        {
                            if (item.IsNotSulfuras())
                            {
                                item.Quality = (item.Quality - 1);
                            }
                        }
                    }
                    else
                    {
                        item.Quality = (item.Quality - item.Quality);
                    }
                }
                else
                {
                    if (item.IsQualityLessThanFifty())
                    {
                        item.Quality = (item.Quality + 1);
                    }
                }
            }
        } 
    }
}
