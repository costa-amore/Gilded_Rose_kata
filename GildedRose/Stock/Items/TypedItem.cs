using GildedRose.Stock.Items.Updaters;

namespace GildedRose.Stock.Items
{
    internal abstract class TypedItem
    {
        private readonly Item item;

        protected TypedItem(Item item)
        {
            this.item = item;
        }

        internal static TypedItem Of(Item item)
        {
            item ??= new Item { Name = "", Quality = 0, SellIn = 0 };
            item.Name ??= string.Empty;

            if (item.Name.Contains("Sulfuras")) return new LegendaryItem(item);
            if (item.Name.Contains("concert")) return new EventItem(item);
            if (item.Name.Contains("Brie")) return new WellAgingItem(item);
            if (item.Name.Contains("Conjured")) return new ConjuredItem(item);

            return new DecayingItem(item);

        }

        internal abstract void Update();

        protected bool BeyondTargetSellDay()
        {
            return item.SellIn < 0;
        }
        protected bool TargetSellDateIn(int targetDays)
        {
            return item.SellIn <= targetDays;
        }

        protected ItemQualityUpdater Quality { get { return new ItemQualityUpdater(item); } }
        protected ItemSellInUpdater SellIn { get { return new ItemSellInUpdater(item); } }

    }
}