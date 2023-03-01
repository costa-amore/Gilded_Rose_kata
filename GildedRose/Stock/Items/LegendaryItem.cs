namespace GildedRose.Stock.Items
{
    internal class LegendaryItem : TypedItem
    {
        #region construction
        internal LegendaryItem(Item item) : base(item)
        {
        }
        #endregion

        internal override void Update()
        {
            return; // legendary items are not impacted by mundane forces !
        }
    }
}