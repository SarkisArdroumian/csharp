using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{   
    [TestFixture]
    public class GildedRoseTest
    {       
        [TestCase("Aged Brie", 2, 0, 1, 1)]
        [TestCase("Conjured Mana Cake", 3, 6, 2, 4)]
        [TestCase("+5 Dexterity Vest", 11, 50, 10, 49)]
        [TestCase("Elixir of the Mongoose", 6, 0, 5, 0)]
        [TestCase("Sulfuras, Hand of Ragnaros", 11, 10, 11, 10)]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 1, 0, 0, 3)]
        [TestCase("+5 Dexterity Vest", -1, 0, -2, 0)]
        public void UpdateItemQuality_Should_Return_The_Expected_Values(string Name, int sellin, int quality, int expectedSellin, int expectedQuality)
        {
            //Arrange
            var item = new Item { Name = Name, Quality = quality, SellIn = sellin };
            GildedRose gildedRose = new GildedRose();

            //Act
            gildedRose.UpdateItemQuality(item);

            //Assert
            Assert.AreEqual(expectedSellin, item.SellIn);
            Assert.AreEqual(expectedQuality, item.Quality);          
        }
    }
}
