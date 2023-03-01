using GildedRose.Items;
    
namespace GildedRose
{
    public class GildedRoseApp
    {
        #region construction
        public IList<Item> Items = new List<Item>();
        private readonly Stock _stock;

        public GildedRoseApp(IList<Item> items)
        {   
            Items = items;
            _stock = new Stock(items); 
        }
        #endregion

        public void UpdateQuality()
        {
            _stock.Update();
        }
    }
}