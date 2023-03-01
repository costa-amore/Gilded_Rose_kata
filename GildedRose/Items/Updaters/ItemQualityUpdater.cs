namespace GildedRose.Items.Updaters
{
    internal class ItemQualityUpdater
    {
        #region construction
        private readonly Item item;

        internal ItemQualityUpdater(Item item)
        {
            this.item = item;
        }
        #endregion

        internal void Increase()
        {
            if (CanIncreaseQuality()) { item.Quality += 1; }
        }
        internal void ReduceTo(int qualityValue)
        {
            item.Quality = qualityValue;
        }
        internal void Reduce()
        {
            if (CanReduceQuality()) { item.Quality -= 1; }
        }

        #region private parts
        private bool CanIncreaseQuality()
        {
            return item.Quality < 50;
        }
        private bool CanReduceQuality()
        {
            return item.Quality > 0;
        }
        #endregion
    }
}