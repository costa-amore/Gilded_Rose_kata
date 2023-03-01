using GildedRose.Items;
using GildedRose;

namespace Gilded_Rose_behavior.UpdateStock
{
    internal class For_conjured_items_should
    {
        [TestCase(5, -2)]
        [TestCase(0, -4)]
        public void Degrade_twice_as_fast_as_normal_items(int sellInValue, int qualityDecay)
        {
            //given
            var qualityValue = 80;
            GildedRoseApp app = new(new List<Item>{
                new Item { Name ="Conjured", Quality = qualityValue, SellIn = sellInValue }
            });

            //when
            app.UpdateQuality();

            //then
            Assert.That(app.Items[0].Quality, Is.EqualTo(qualityValue + qualityDecay));
        }
    }
}
