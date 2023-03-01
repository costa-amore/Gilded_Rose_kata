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
            for (var i = 0; i < _stock.Count; i++)
            {
                if (_stock._typedItems[i].Name != "Aged Brie" && _stock._typedItems[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (_stock._typedItems[i].Quality > 0)
                    {
                        if (_stock._typedItems[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            _stock._typedItems[i].UpdateQuality(- 1);
                        }
                    }
                }
                else
                {
                    if (_stock._typedItems[i].Quality < 50)
                    {
                        _stock._typedItems[i].UpdateQuality(+ 1);

                        if (_stock._typedItems[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (_stock._typedItems[i].SellIn < 11)
                            {
                                if (_stock._typedItems[i].Quality < 50)
                                {
                                    _stock._typedItems[i].UpdateQuality(+ 1);
                                }
                            }

                            if (_stock._typedItems[i].SellIn < 6)
                            {
                                if (_stock._typedItems[i].Quality < 50)
                                {
                                    _stock._typedItems[i].UpdateQuality(+ 1);
                                }
                            }
                        }
                    }
                }

                if (_stock._typedItems[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    _stock._typedItems[i].UpdateSellIn(- 1);
                }

                if (_stock._typedItems[i].SellIn < 0)
                {
                    if (_stock._typedItems[i].Name != "Aged Brie")
                    {
                        if (_stock._typedItems[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (_stock._typedItems[i].Quality > 0)
                            {
                                if (_stock._typedItems[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    _stock._typedItems[i].UpdateQuality(- 1);
                                }
                            }
                        }
                        else
                        {
                            _stock._typedItems[i].UpdateQuality(-_stock._typedItems[i].Quality);
                        }
                    }
                    else
                    {
                        if (_stock._typedItems[i].Quality < 50)
                        {
                            _stock._typedItems[i].UpdateQuality(+ 1);
                        }
                    }
                }
            }
        }
    }
}