namespace GildedRose
{
    internal class LegendaryItem : TypedItem
    {
        public LegendaryItem(Item item) : base(item)
        {
        }

    }
    internal class TypedItem
    {
        private readonly Item item;
        private readonly ItemType type;

        public TypedItem(Item item)
        {
            this.item = item;
            type = DefineTypeOf(item);
        }

        public static TypedItem Of(Item item)
        {
            if (item.Name.Contains("Sulfuras")) return new LegendaryItem(item);

            return new TypedItem(item);

        }
        private static ItemType DefineTypeOf(Item item)
        {
            if (item.Name.Contains("Sulfuras")) return ItemType.legendary;
            if (item.Name.Contains("concert"))  return ItemType.eventItem;
            if (item.Name.Contains("Brie"))     return ItemType.wellAging;

            return ItemType.decaying;
        }

        public string Name { get { return item.Name; } }
        public int SellIn { get { return item.SellIn; } }
        public int Quality { get { return item.Quality; } }

        public ItemType Type { get { return type; } }
 
        public override string ToString()
        {
            return this.item.ToString();
        }

        internal void UpdateQuality(int updateQualityWith)
        {
            item.Quality += updateQualityWith;
        }

        internal void UpdateSellIn(int updateSellInWith)
        {
            item.SellIn += updateSellInWith;
        }
    }


    enum ItemType
    {
        decaying,
        legendary,
        wellAging,
        eventItem
    }
}