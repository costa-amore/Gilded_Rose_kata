using GildedRose.Items;
using GildedRose;

namespace Gilded_Rose_behavior.UpdateStock
{
    public class For_legendary_items_should
    {
        [TestCase(5)]
        [TestCase(0)]
        [TestCase(-1)]
        public void Never_affect_legendary_items(int sellinValue)
        {
            //given
            var qualityValue = 80;
            GildedRoseApp app = new(new List<Item>{
                new Item { Name ="Sulfuras, Hand of Ragnaros", Quality = qualityValue, SellIn = sellinValue }
            });

            //when
            app.UpdateQuality();

            //then
            Assert.Multiple(() =>
            {
                Assert.That(app.Items[0].Quality, Is.EqualTo(qualityValue));
                Assert.That(app.Items[0].SellIn, Is.EqualTo(sellinValue));
            });
        }
    }
}
