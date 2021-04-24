using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace csharp
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class ApprovalTest
    {
        [Test]
        public void ThirtyDays()
        {
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            var output = fakeoutput.ToString();

            Approvals.Verify(output);
        }

        [Test]
        public void updateQuality()
        {
            CombinationApprovals.VerifyAllCombinations
            (
                doUpdateQuality,
                new string[]
                {
                     "+5 Dexterity Vest",
                     "Aged Brie",
                     "Elixir of the Mongoose",
                     "Sulfuras, Hand of Ragnaros",
                     "Backstage passes to a TAFKAL80ETC concert",
                     "Conjured Mana Cake"
                },
                new int[] { -1, 1, 0, 6, 11 },
                new int[] { 0, 10, 50 }
            );
        }

        private string doUpdateQuality(string name, int sellIn, int quality)
        {
            Item[] items = new Item[] { new Item { Name = name, SellIn = sellIn, Quality = quality } };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            return app.Items[0].ToString();
        }
    }
}
