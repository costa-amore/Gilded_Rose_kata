namespace GildedRose.Stock.Items
{
    internal class EventItem : TypedItem
    {
        #region construction
        internal EventItem(Item item) : base(item)
        {
        }
        #endregion

        internal override void Update()
        {
            Quality.Increase();

            if (TargetSellDateIn(10))
            {
                Quality.Increase();
            }

            if (TargetSellDateIn(5))
            {
                Quality.Increase();
            }

            SellIn.Reduce();

            if (BeyondTargetSellDay())
            {
                Quality.ReduceTo(0);
            }
        }

    }
}