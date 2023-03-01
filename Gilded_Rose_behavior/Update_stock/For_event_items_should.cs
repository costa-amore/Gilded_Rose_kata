using GildedRose;
using GildedRose.Items;

namespace Gilded_Rose_behavior.Update_stock
{ 
    public class For_event_items_should
    {
        [TestCase(11, 1)]
        [TestCase(10, 2)]
        [TestCase(6, 2)]
        [TestCase(5, 3)]
        [TestCase(1, 3)]
        public void Increase_quality_exponentially_of_event_type_items(int sellinValue, int valueIncrease)
        {   //given
            var qualityValue = 10;
            GildedRoseApp app = Setup.App("Backstage passes to a TAFKAL80ETC concert", qualityValue, sellinValue );

            //when
            app.UpdateQuality();

            //then
            Assert.That(app.Items[0].Quality, Is.EqualTo(qualityValue + valueIncrease));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void Drop_quality_to_ZERO_for_events_in_the_past(int sellinValue)
        {   //given
            GildedRoseApp app = Setup.App("Backstage passes to a TAFKAL80ETC concert", 10, sellinValue );

            //when
            app.UpdateQuality();

            //then
            Assert.That(app.Items[0].Quality, Is.EqualTo(0));
        }
    }
}