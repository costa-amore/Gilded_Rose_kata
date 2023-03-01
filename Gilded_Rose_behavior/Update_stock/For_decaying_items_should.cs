using GildedRose;

namespace Gilded_Rose_behavior.Update_stock
{
    public class For_decaying_items_should
    {
        [Test]
        public void Decrease_sellIn_and_quality_by_1()
        {   //given
            var sellinValue = 1;
            var qualityValue = 1;
            GildedRoseApp app = Setup.App("test", qualityValue, sellinValue);

            //when
            app.UpdateQuality();

            //then
            Assert.Multiple(() =>
            {
                Assert.That(app.Items[0].SellIn, Is.EqualTo(sellinValue - 1));
                Assert.That(app.Items[0].Quality, Is.EqualTo(qualityValue - 1));
            });
        }

        [Test]
        public void Decrease_quality_twice_as_fast_after_sell_by_date_has_passed()
        {   //given
            var qualityValue = 10;
            GildedRoseApp app = Setup.App("test", qualityValue, 0);

            //when
            app.UpdateQuality();

            //then
            Assert.That(app.Items[0].Quality, Is.EqualTo(qualityValue - 2));
        }

        [TestCase(0, 1)]
        [TestCase(0, 0)]
        public void Never_decrease_the_quality_below_zero(int quality, int sellin)
        {   //given
            GildedRoseApp app = Setup.App("test", quality, sellin );

            //when
            app.UpdateQuality();

            //then
            Assert.That(app.Items[0].Quality, Is.EqualTo(0));
        }
    } 
}