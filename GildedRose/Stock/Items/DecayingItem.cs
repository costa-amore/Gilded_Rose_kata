namespace GildedRose.Stock.Items
{
    internal class DecayingItem : TypedItem
    {
        #region construction
        public DecayingItem(Item item) : base(item)
        {
        }
        #endregion

        internal override void Update()
        {
            Quality.Reduce();

            SellIn.Reduce();

            if (BeyondTargetSellDay())
            {
                Quality.Reduce();
            }
        }

    }
}