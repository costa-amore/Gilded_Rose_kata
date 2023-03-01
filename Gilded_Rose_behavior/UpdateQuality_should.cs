using GildedRose;

namespace Gilded_Rose_behavior
{
    public class UpdateQuality_should
    {

        [Test]
        public void Decrease_sellIn_and_quality_by_1()
        {
            //given
            var sellinValue = 1;
            var qualityValue = 1;
            GildedRoseApp app = new(new List<Item>{
                new Item { Name ="test", Quality = qualityValue, SellIn = sellinValue }
            });

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
        {
            //given
            var qualityValue = 10;
            GildedRoseApp app = new(new List<Item>{
                new Item { Name ="test", Quality = qualityValue, SellIn = 0 }
            });

            //when
            app.UpdateQuality();

            //then
            Assert.That(app.Items[0].Quality, Is.EqualTo(qualityValue - 2));
        }

        [TestCase(0, 1)]
        [TestCase(0, 0)]
        public void Never_decrease_the_quality_below_zero(int quality, int sellin)
        {
            //given
            GildedRoseApp app = new(new List<Item>{
                new Item { Name ="test", Quality = quality, SellIn = sellin }
            });

            //when
            app.UpdateQuality();

            //then
            Assert.That(app.Items[0].Quality, Is.EqualTo(0));
        }

        [TestCase("Aged Brie")]
        [TestCase("Backstage passes to a TAFKAL80ETC concert")]
        public void Increase_quality_of_well_aging_items(string itemName)
        {   
            //given
            var qualityValue = 10;
            GildedRoseApp app = new(new List<Item>{
                new Item { Name =itemName, Quality = qualityValue, SellIn = 11 }
            });

            //when
            app.UpdateQuality();

            //then
            Assert.That(app.Items[0].Quality, Is.EqualTo(qualityValue +1));
        }

        [TestCase(11, 1)]
        [TestCase(10, 2)]
        [TestCase(6, 2)]
        [TestCase(5, 3)]
        [TestCase(1, 3)]
        public void Increase_quality_exponentially_of_event_type_items(int sellinValue, int valueIncrease)
        {
            //given
            var qualityValue = 10;
            GildedRoseApp app = new(new List<Item>{
                new Item { Name ="Backstage passes to a TAFKAL80ETC concert", Quality = qualityValue, SellIn = sellinValue }
            });

            //when
            app.UpdateQuality();

            //then
            Assert.That(app.Items[0].Quality, Is.EqualTo(qualityValue + valueIncrease));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void Drop_quality_to_ZERO_for_events_in_the_past(int sellinValue)
        {
            //given
            GildedRoseApp app = new(new List<Item>{
                new Item { Name ="Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = sellinValue }
            });

            //when
            app.UpdateQuality();

            //then
            Assert.That(app.Items[0].Quality, Is.EqualTo(0));
        }

        [Test]
        public void Never_increase_quality_beyond_50()
        {
            //given
            var qualityValue = 50;
            GildedRoseApp app = new(new List<Item>{
                new Item { Name ="Aged Brie", Quality = qualityValue, SellIn = 5 }
            });

            //when
            app.UpdateQuality();

            //then
            Assert.That(app.Items[0].Quality, Is.EqualTo(qualityValue));
        }

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