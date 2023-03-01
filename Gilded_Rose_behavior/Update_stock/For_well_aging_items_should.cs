using GildedRose;

namespace Gilded_Rose_behavior.UpdateStock
{
    public class For_well_aging_items_should
    {
        [Test]
        public void Increase_quality_of_well_aging_items_twice_as_fast_after_sell_by_date_has_passed()
        {   //given
            var qualityValue = 10;
            GildedRoseApp app = Setup.App("Brie", qualityValue, 0 );

            //when
            app.UpdateQuality();

            //then
            Assert.That(app.Items[0].Quality, Is.EqualTo(qualityValue + 2));
        }


        [Test]
        public void Never_increase_quality_beyond_50()
        {   //given
            var qualityValue = 50;
            GildedRoseApp app = Setup.App("Aged Brie", qualityValue, 5);

            //when
            app.UpdateQuality();

            //then
            Assert.That(app.Items[0].Quality, Is.EqualTo(qualityValue));
        }


        [TestCase("Aged Brie")]
        [TestCase("Backstage passes to a TAFKAL80ETC concert")]
        public void Increase_quality_of_well_aging_items(string itemName)
        {   //given
            var qualityValue = 10;
            GildedRoseApp app = Setup.App(itemName, qualityValue, 11 );

            //when
            app.UpdateQuality();

            //then
            Assert.That(app.Items[0].Quality, Is.EqualTo(qualityValue + 1));
        }
    }
}