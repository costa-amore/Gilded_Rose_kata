using GildedRose;

namespace Gilded_Rose_behavior.Update_stock
{
    public static class Setup
    {
        public static GildedRoseApp App(string itemName, int qualityValue, int sellinValue)
        {
            return new(new List<Item>{
                new Item { Name = itemName, Quality = qualityValue, SellIn = sellinValue }
            });

        }

    }
}
