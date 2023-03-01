using GildedRoseStock = GildedRose.Stock.Stock;

namespace GildedRose
{
    public class GildedRoseApp
    {
        #region construction
        public IList<Item> Items = new List<Item>();
        private readonly GildedRoseStock _stock;

        public GildedRoseApp(IList<Item> items)
        {   
            Items = items;
            _stock = new GildedRoseStock(items); 
        }
        #endregion

        public void UpdateQuality()
        {
            _stock.Update();
        }
    }
}