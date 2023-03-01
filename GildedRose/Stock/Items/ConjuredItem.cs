namespace GildedRose.Stock.Items
{
    internal class ConjuredItem : TypedItem
    {
        #region construction
        public ConjuredItem(Item item) : base(item)
        {
        }
        #endregion

        internal override void Update()
        {
            Quality.ReduceBy(2);

            SellIn.Reduce();

            if (BeyondTargetSellDay())
            {
                Quality.ReduceBy(2);
            }
        }
    }
}