using System.Text.Json;

namespace GildedRose
{
    public class GildedRoseApp
    {
        public IList<Item> Items = new List<Item>();
        private readonly Stock _stock;

        public GildedRoseApp(IList<Item> items)
        {   
            Items = items;
            _stock = new Stock(items); 
        }
       
        public void UpdateQuality()
        {
            foreach (var item in _stock)
            {
                item.Update();
            }
        }
    }
}