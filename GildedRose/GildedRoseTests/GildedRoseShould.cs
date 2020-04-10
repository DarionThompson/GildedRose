using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Katas
{
    public class GuildedRoseTest
    {
        [Fact]
        public void UpdateItems()
        {
            //Arrange
            var itemsList = CreateList();
            var gildedRose = new GildedRose(itemsList);
            var expectedContent = GetExpctedResults();

            //Act
            gildedRose.updateQuality();

            //Assert
            itemsList.Should().BeEquivalentTo(expectedContent);
        }

        private List<Item> CreateList()
        {
            var items = new List<Item>
            {
                new Item("+5 Dexterity Vest", 10, 20),
                new Item("Aged Brie", 2, 0),
                new Item("Elixir of the Mongoose", 5, 7),
                new Item("Sulfuras, Hand of Ragnaros", 0, 80),
                new Item("Sulfuras, Hand of Ragnaros", -1, 80),
                new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20)
            };

            return items;
        }

        private List<Item> GetExpctedResults()
        {
            return new List<Item>()
            {
                new Item("+5 Dexterity Vest", 9, 19),
                new Item("Aged Brie", 1, 1),
                new Item("Elixir of the Mongoose", 4, 6),
                new Item("Sulfuras, Hand of Ragnaros", 0, 80),
                new Item("Sulfuras, Hand of Ragnaros", -1, 80),
                new Item("Backstage passes to a TAFKAL80ETC concert", 14, 21)
            };
        }
    }
}