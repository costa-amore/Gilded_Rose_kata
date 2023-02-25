using GildedRose;

namespace Gilded_Rose_behavior
{
    public class Tests
    {
        [Test]
        public void foo()
        {
            //given
            GildedRoseApp app = new GildedRoseApp();
            
            //when
            app.UpdateQuality();

            //then
            Assert.AreEqual("fixme", app.Items[0].Name);
        }
    }
}