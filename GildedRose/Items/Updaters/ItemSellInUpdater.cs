namespace GildedRose.Items.Updaters
{
    internal class ItemSellInUpdater
    {
        #region construction
        private readonly Item item;

        public ItemSellInUpdater(Item item)
        {
            this.item = item;
        }
        #endregion

        internal void Reduce()
        {
            item.SellIn -= 1;
        }

    }
}