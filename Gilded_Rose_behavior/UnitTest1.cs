using GildedRose;

namespace Gilded_Rose_behavior
{
    public class Tests
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRoseApp app = new GildedRoseApp(Items);
            app.UpdateQuality();

            Assert.AreEqual("fixme", Items[0].Name);
        }
    }
}