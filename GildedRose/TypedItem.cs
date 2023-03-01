namespace GildedRose
{
    internal abstract class TypedItem
    {
        private readonly Item item;

        protected TypedItem(Item item)
        {
            this.item = item;
        }

        public static TypedItem Of(Item item)
        {
            item ??= new Item { Name="", Quality = 0, SellIn = 0 };
            item.Name ??= string.Empty;

            if (item.Name.Contains("Sulfuras")) return new LegendaryItem(item);
            if (item.Name.Contains("concert")) return new EventItem(item);
            if (item.Name.Contains("Brie")) return new WellAgingItem(item);

            return new DecayingItem(item);

        }

        public string Name { get { return item.Name; } }
        public int SellIn { get { return item.SellIn; } }
        public int Quality { get { return item.Quality; } }
 
        public override string ToString()
        {
            return this.item.ToString();
        }

        internal void UpdateQuality(int updateQualityWith)
        {
            item.Quality += updateQualityWith;
        }

        internal void UpdateSellIn(int updateSellInWith)
        {
            item.SellIn += updateSellInWith;
        }

        public abstract void Update();


        protected void IncreaseQuality(int increase)
        {
            if (CanIncreaseQuality())
            {
                UpdateQuality(+1);
            }
        }

        protected bool CanIncreaseQuality()
        {
            return Quality < 50;
        }

        protected bool CanReduceQuality()
        {
            return Quality > 0;
        }
 
    }

    internal class DecayingItem : TypedItem
    {
        public DecayingItem(Item item) : base(item)
        {
        }

        public override void Update()
        {
            if (CanReduceQuality())
            {
                UpdateQuality(-1);
            }

            UpdateSellIn(-1);

            if (SellIn < 0)
            {
                if (CanReduceQuality())
                {
                    UpdateQuality(-1);
                }
            }
        }

    }

    internal class WellAgingItem : TypedItem
    {
        public WellAgingItem(Item item): base(item)
        {
        }

        public override void Update()
        {
            if (CanIncreaseQuality())
            {
                UpdateQuality(+1);
            }

            UpdateSellIn(-1);

            if (SellIn < 0)
            {
                if (CanIncreaseQuality())
                {
                    UpdateQuality(+1);
                }
            }
        }

    }

    internal class LegendaryItem : TypedItem
    {
        public LegendaryItem(Item item) : base(item)
        {
        }

        public override void Update()
        {
            return;
        }
    }
    
    internal class EventItem : TypedItem
    {
        public EventItem(Item item) : base(item)
        {
        }

        public override void Update()
        {
            if (CanIncreaseQuality())
            {
                UpdateQuality(+1);

                if (SellIn < 11)
                {
                    if (CanIncreaseQuality())
                    {
                        UpdateQuality(+1);
                    }
                }

                if (SellIn < 6)
                {
                    if (CanIncreaseQuality())
                    {
                        UpdateQuality(+1);
                    }
                }
            }

            UpdateSellIn(-1);

            if (SellIn < 0)
            {
                UpdateQuality(-Quality);
            }
        }
    }
}