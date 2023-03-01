using GildedRose;

namespace Gilded_Rose_behavior.Update_stock
{
    public class For_legendary_items_should
    {
        [TestCase(5)]
        [TestCase(0)]
        [TestCase(-1)]
        public void Never_affect_legendary_items(int sellinValue)
        {   //given
            var qualityValue = 80;
            GildedRoseApp app = Setup.App("Sulfuras, Hand of Ragnaros", qualityValue, sellinValue);

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
