namespace GildedRose.Items
{
    internal class WellAgingItem : TypedItem
    {
        #region construction
        internal WellAgingItem(Item item) : base(item)
        {
        }
        #endregion

        internal override void Update()
        {
            Quality.Increase();

            SellIn.Reduce();

            if (BeyondTargetSellDay())
            {
                Quality.Increase();
            }
        }
    }
}